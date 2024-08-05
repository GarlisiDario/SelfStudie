using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace TodoLibrary.entity
{
    public class TodoList
    {
        private int Id { get; set; }
        public string Todo { get; set; }
        public DateTime DateNow { get {return DateTime.Now; } }
        public DateTime EndDate { get; set; }

        public void SafeTodoFile(string path)
        {
            try
            {
                using (StreamWriter sw = (File.Exists(path)) ? File.AppendText(path) : File.CreateText(path))
                {

                }

            }
            catch(FileNotFoundException ex)
            {
                throw new InvalidDataException(ex + "File not found or cant read.");
            }
            catch (Exception e)
            {

                throw new ArgumentException($"{e}");
            }
        }
        
    }
}
