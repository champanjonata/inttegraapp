using inttegraapp.Models;
using CsvHelper;
using System.Collections.Generic;
using System.IO;

namespace inttegraapp.Facades
{
    public class ContatosImport
    {
        private List<Contato> rows = new List<Contato>();

        public void ImportData(string fileName)
        {
            try
            {
                using (var fs = new StreamReader(fileName))
                {                    
                    rows = new CsvHelper.CsvReader((IParser)fs).GetRecords<Contato>().ToList();
                }
            }
            catch (Exception ex)
            {

            }
        }
    }
}
