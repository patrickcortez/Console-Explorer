using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Console
{
    class Explorer //For future use
    {
        List<Explorer> NewExplore = new List<Explorer>();
        string dir_name;
        List<string> files = new List<string>();
        Explorer(string current, string[] Files)
        {
            dir_name = current;
            files = Files.ToList();
        }

        public void CreateNewInstance(string nextDir, string[] Files)
        {
            Explorer tmp = new Explorer(nextDir, Files);

            NewExplore.Add(tmp);
        }
    }

    internal static class Utility
    {

        public static void CopyDirectory(string source,string destination)
        {
            try
            {
                if (!Directory.Exists(destination))
                {
                    return;
                }

                DialogResult res = MessageBox.Show("Are you sure any duplicate file found in dest will be overwritten.", "warning", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (res == DialogResult.No)
                {
                    return;
                }


                var dirs = new DirectoryInfo(source);

                foreach (FileInfo file in dirs.GetFiles())
                {
                    string tarpath = Path.Combine(destination, file.Name);
                    file.CopyTo(tarpath, true);
                }

                foreach (DirectoryInfo subdir in dirs.GetDirectories())
                {
                    string ndir = Path.Combine(source, subdir.Name);
                    CopyDirectory(ndir, destination);
                }

            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public static string[] TokenizeString(string input) // this is our new tokenizer, that handles qoutes by using a boolean to check each character for qoutes
        {
            List<string> Tokens = new List<string>(); // we store each token we find in the tokenization loop
            StringBuilder word = new StringBuilder();
            bool isQoutes = false;
            
            foreach(char c in input) // Our Tokenization loop
            {
                if(c == '"') // if we encounter a qoute we trigger our isQoutes by reversing its value then if we reach an end qoute it beautifully sets it to false =D recording the entire string
                {
                    isQoutes = !isQoutes;
                    continue;
                }
                
                if(c == ' ' && !isQoutes) // once we reach an empty space that isnt a qoute we finally add the 'word' to our list and clear the string builder
                { //this is also extensible for later
                    if(word.Length > 0) // our guard clause 
                    {
                        Tokens.Add(word.ToString());
                        word.Clear();
                    }
                   
                }
                else // extensible logic here
                {
                    word.Append(c);
                   
                }

            }

            if(word.Length > 0) // final check for the last token
            {
                Tokens.Add(word.ToString());
            }

            return Tokens.ToArray(); //Finally return the entire list
        }

        public static char GetFlag(string option, params char[] prefix)
        {
            char flag = option.Trim(prefix)[0];

            return flag;
        }


    }
}
