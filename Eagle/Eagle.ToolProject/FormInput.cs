using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Reflection;
using System.IO;
using Microsoft.CSharp;
using System.CodeDom.Compiler;


namespace Eagle.ToolProject
{
    public partial class FormInput : Form
    {
        public FormInput()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 判断该属性是否是数据库字段。
        /// True：不是。
        /// False:是。
        /// </summary>
        static private bool CheckReturnEntity(System.Reflection.PropertyInfo p)
        {
            if (p.Name.Contains("Changed") || p.Name.Contains("CompareParam") || p.Name.Contains("DbType"))
            {
                return true;
            }
            return false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ////1.生成前台页面 模版JsTest
            //string TableName = "TicketTypeArea";//点1
            //string ModelStr = MainForm.ReadModel("model/PageModel/aspx.aspx");
            //ModelStr = ModelStr.Replace("JsTest.aspx.cs", TableName + "Entity.aspx.cs");
            //ModelStr = ModelStr.Replace("TicketBusiness.Default", "TicketBusiness." + TableName);
            ////2.生成Form子项
            //StringBuilder Items = new System.Text.StringBuilder();
            //string ItemRegExp = MainForm.ReadModel("model/PageModel/FormItem.txt");
            //PropertyInfo[] PList = typeof(TicketTypeAreaEntity).GetProperties();//点2
            //foreach (PropertyInfo p in PList)
            //{
            //    if (CheckReturnEntity(p))
            //    {
            //        continue;
            //    }
            //    Items.Append(ItemRegExp.Replace("{0}", p.Name.ToString()));
            //}
            //ModelStr = ModelStr.Replace("StringGenerateCode", Items.ToString());
            ////3.生成文件
            //WriteFile(ModelStr, TableName + "Entity.aspx");
            ////4.生成后台文件
            //ModelStr = MainForm.ReadModel("model/PageModel/aspx.aspx.cs");
            //ModelStr = ModelStr.Replace("Default", TableName);
            //ModelStr = ModelStr.Replace("VoucherDal", TableName + "Dal");
            //ModelStr = ModelStr.Replace("VoucherEntity", TableName + "Entity");
            //WriteFile(ModelStr, TableName + "Entity.aspx.cs");
            ////5.生成设计文件
            //ModelStr = MainForm.ReadModel("model/PageModel/aspx.aspx.designer.cs");
            //ModelStr = ModelStr.Replace("Default", TableName);
            //WriteFile(ModelStr, TableName + "Entity.aspx.designer.cs");
            //System.Diagnostics.Process.Start("Explorer.exe", System.Environment.CurrentDirectory + "\\GeneratedFiles\\");
        }

        public void WriteFile(string FileContentStr, string TableName)
        {
            string Dir = "GeneratedFiles/Page/Generated/";
            if (!Directory.Exists(Dir))
            {
                Directory.CreateDirectory(Dir);
            }
            // 检查文件是否存在
            string FileName = Dir + TableName;
            if (File.Exists(FileName))
            {
                //删除文件
                File.Delete(FileName);
            }
            FileStream MyFile = new FileStream(FileName, FileMode.Create);
            StreamWriter Writer = new StreamWriter(MyFile, Encoding.UTF8);
            Writer.Write(FileContentStr);
            Writer.Close();
            MyFile.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //UserEntity entity = new UserEntity();
            //entity.UserId = 5;
            //entity.UserName = "张桂华";
            //GenericDal<UserEntity>.Delete(entity);
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            
        }

        private void Test()
        {
            /* 根据传入类名称动态创建实体对象 */
            object Obj = System.Reflection.Assembly.GetExecutingAssembly().CreateInstance("工具项目.UserEntity", false);
            /* 获取对象类型 */
            Type ObjType = Obj.GetType();
            /* 调用对象方法 */
            List<PropertyInfo> PropertyList = (List<PropertyInfo>)ObjType.InvokeMember("GetPrimaryKeys", BindingFlags.Default | BindingFlags.InvokeMethod, null, Obj, null);
           
            foreach (PropertyInfo P in PropertyList)
            {
                MessageBox.Show(P.Name);
            }
            /* 实例化对象 */



            ////实体类类型和实体为传入参数，调用DAL类
            //Type tx = typeof(GenericDal<>);
            //Type.GetType("");
            //tx = tx.MakeGenericType(typeof(UserEntity));
            ////object o = Activator.CreateInstance(tx);
            //tx.InvokeMember("Insert", BindingFlags.Default | BindingFlags.InvokeMethod, null, null, new object[] { new UserEntity(){UserId=100}});
            //MessageBox.Show(tx.ToString());
         
        }

        static string GenerateCode()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("using System;");
            sb.Append(Environment.NewLine);
            sb.Append("namespace DynamicCodeGenerate");
            sb.Append(Environment.NewLine);
            sb.Append("{");
            sb.Append(Environment.NewLine);
            sb.Append("      public class HelloWorld");
            sb.Append(Environment.NewLine);
            sb.Append("      {");
            sb.Append(Environment.NewLine);
            sb.Append("          public string OutPut()");
            sb.Append(Environment.NewLine);
            sb.Append("          {");
            sb.Append(Environment.NewLine);
            sb.Append("               return \"Hello world!\";");
            sb.Append(Environment.NewLine);
            sb.Append("          }");
            sb.Append(Environment.NewLine);
            sb.Append("      }");
            sb.Append(Environment.NewLine);
            sb.Append("}");
            return sb.ToString();
        }

        #region 动态编译与执行代码

        /// <summary>
        /// 编译源代码,并返回编译后的程序集
        /// </summary>
        /// <param name="SourceCode"></param>
        /// <returns></returns>
        public Assembly CompileSourceCode(string SourceCode)
        {
            /*创建编译器实例*/
            CSharpCodeProvider objCSharpCodePrivoder = new CSharpCodeProvider();
            /*设置编译参数*/
            CompilerParameters objCompilerParameters = new CompilerParameters();
            objCompilerParameters.ReferencedAssemblies.Add("System.dll");
            /*是否产生exe执行文件*/
            objCompilerParameters.GenerateExecutable = false;
            objCompilerParameters.GenerateInMemory = false;
            /*设置文件保存位置*/
            objCompilerParameters.OutputAssembly = "test.dll";
            /*编译*/
            CompilerResults cr = objCSharpCodePrivoder.CompileAssemblyFromSource(objCompilerParameters, SourceCode);
            if (cr.Errors.HasErrors)
            {
                /*编译失败*/
                string ErroMesg = string.Empty;
                foreach (CompilerError err in cr.Errors)
                {
                    ErroMesg += err.ErrorText;
                }
                MessageBox.Show("编译错误：" + ErroMesg);
                /*编译失败返回null*/
                return null;
            }
            else
            {
                /*编译成功，返回程序集*/
                Assembly objAssembly = cr.CompiledAssembly;
                return objAssembly;
            }
        }

        /// <summary>
        /// 动态加载Dll文件
        /// </summary>
        /// <param name="FileName">Dll文件名</param>
        /// <returns>程序集</returns>
        public Assembly LoadDllFromFile(string FileName)
        {
            byte[] filesByte = File.ReadAllBytes(Path.GetDirectoryName(Application.ExecutablePath) + "//" + FileName);
            Assembly assembly = Assembly.Load(filesByte);
            return assembly;
        }

        /// <summary>
        /// 调用程序集里面的方法
        /// </summary>
        /// <param name="objAssembly">程序集</param>
        /// <param name="ClassFullName">方法名（全路径）</param>
        public void RunAssemblyMethod(Assembly objAssembly,string ClassFullName,string MethodName,object[] ObjParam)
        {
            /*创建类实例*/
            object objHelloWorld = objAssembly.CreateInstance(ClassFullName);
            /*获取方法入口*/
            MethodInfo objMI = objHelloWorld.GetType().GetMethod("MethodName");
            /*调用方法*/
            objMI.Invoke(objHelloWorld, ObjParam).ToString();
        }

        #endregion

    }
}
