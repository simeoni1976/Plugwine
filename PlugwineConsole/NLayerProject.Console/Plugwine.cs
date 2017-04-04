using NLayerProject.Core.Helpers;
using NLayerProject.Models;
using System;
using System.Text;
using NLayerProject.Helpers;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;

namespace NLayerProject
{
    public class Plugwine
    {
        private readonly HttpRequestProvider _httpRequestProvider;

        /// <summary>
        /// Constructor
        /// </summary>
        public Plugwine()
        {
            _httpRequestProvider = new HttpRequestProvider();
            Console.OutputEncoding = Encoding.Unicode;
        }

        /// <summary>
        /// Execute
        /// </summary>
        public async Task Exec()
        {
            while(true)
            {
                var forms = await _httpRequestProvider.GetForms();

                if(forms != null) { 
                    WriteHr(10);
                    DisplayPrices(forms);
                    WriteHr(10);
                    DisplayOtherPrices(forms);
                }

                Console.WriteLine("Please enter an action :");
                string entry = Console.ReadLine();

                var formTable = ToolHelper.GetData(entry);
                var errorMessage = string.Empty;
                try
                {
                    if(!ToolHelper.IsCorrect(formTable))
                    {
                        errorMessage = "/!\\ Entry format is not correct.\n";
                        throw new Exception();
                    }

                    FormModel formModel = new FormModel();
                    formModel.FormId = 0;
                    formModel.FormName = formTable[0];
                    formModel.FormTypeName = formTable[1];
                    formModel.Area = int.Parse(formTable[2]);

                    var response = await _httpRequestProvider.Post(formModel);
                    WriteCrlf();
                }
                catch(Exception)
                {
                    var normalColor = Console.ForegroundColor;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(errorMessage, "/!\\ Error while the treatment. Check if the datas are corrects.");
                    Console.ForegroundColor = normalColor;
                }
            }
        }

        private void DisplayPrices(IEnumerable<FormModel> forms)
        {
            StringBuilder sb = new StringBuilder();
            forms.ToList().ForEach(item => sb.AppendFormat("{0}-{1}-{2} Estimation à {3} E \n",
                item.FormName,
                item.FormTypeName,
                item.Area,
                _httpRequestProvider.GetPrice(item.Area).Result
                ));

            Console.WriteLine(sb);
        }

        private void DisplayOtherPrices(IEnumerable<FormModel> forms)
        {
            StringBuilder sb = new StringBuilder();
            forms.ToList().ForEach(item => sb.AppendFormat("{0}-{1}-{2} Estimation à {3} E \n",
                item.FormName,
                item.FormTypeName,
                item.Area,
                _httpRequestProvider.GetOtherPrice(item.Area).Result
                ));

            Console.WriteLine(sb);
        }

        private void WriteCrlf()
        {
            Console.WriteLine("\n");
        }

        private void WriteHr(int length)
        {
            var hr = new String('-', length);
            Console.WriteLine(hr);
        }
    }
}
