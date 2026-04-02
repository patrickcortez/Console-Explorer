using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace Console
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
            lb_path.Text = currentDirectory.FullName;
            rtb_output.Text = "Welcome to File System Console" + Environment.NewLine;
            rtb_output.Text += "Type 'help' to begin exploring!" + Environment.NewLine + Environment.NewLine;
        }

        string input = string.Empty;
        DirectoryInfo currentDirectory = new DirectoryInfo(Environment.GetEnvironmentVariable("USERPROFILE"));


        void print(string text)
        {
            rtb_output.Text += text + Environment.NewLine;
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            input = tb_input1.Text;
            mainLoop();
            tb_input1.Text = string.Empty;
        }

        private void help()
        {
            print("Available Commands:");
            print("echo <text> - Prints the text to the console.");
            print("clear - Clears the console output.");
            print("current - Displays the current directory.");
            print("change <directory-path> - Changes the current directory to the specified path.");
            print("list <directory-path> - Lists all the files in the directory");
            print("create <file/directory> <name> - Creates a file or directory.");
            print("delete <file/directory> <name> - Deletes a file or directory.");
        }

        private void mainLoop()
        {
            string[] cmd = input.Split(' ');
            if (cmd[0].ToLower() == "echo")
            {
                print(string.Join(" ", cmd.Skip(1)));
            }
            else if (cmd[0].ToLower() == "clear")
            {
                rtb_output.Text = string.Empty;
            }
            else if (cmd[0].ToLower() == "current")
            {
                print(currentDirectory.FullName);
            }
            else if (cmd[0].ToLower() == "change")
            {
                if (cmd.Length < 2)
                {
                    print("Usage: change <directory-path>");
                    return;
                }

                string newPath;

                if (Path.IsPathRooted(cmd[1])) //if its an Absolute path
                {

                    newPath = cmd[1];
                }
                else // Relative path
                {

                    newPath = Path.Combine(currentDirectory.FullName, cmd[1]);
                }

                var newDir = new DirectoryInfo(newPath);

                if (!newDir.Exists)
                {
                    print("Directory does not exist: " + newPath);
                    return;
                }

                currentDirectory = newDir;
                lb_path.Text = currentDirectory.FullName;
            }
            else if (cmd[0].ToLower() == "help")
            {
                help();
            }
            else if (cmd[0].ToLower() == "list")
            {
                var path = Path.Combine(currentDirectory.FullName, cmd[1]);

                var listf = Directory.GetFiles(path);
                var listd = Directory.GetDirectories(path);

                foreach (var dir in listd)
                {
                    print("[DIR] " + Path.GetFileName(dir));
                }

                print(Environment.NewLine);

                foreach (var file in listf)
                {
                    print("[FILE] " + Path.GetFileName(file));
                }

            }
            else if (cmd[0].ToLower() == "create")
            {
                var path = Path.Combine(currentDirectory.FullName, cmd[2]);

                if (cmd.Length < 3)
                {
                    print("Usage: create <file/directory> <name>");
                }

                if (cmd[1].ToLower() == "file")
                {
                    File.Create(path).Close();
                    print("File: " + cmd[2] + " created successfully.");
                }
                else if (cmd[1].ToLower() == "directory")
                {
                    Directory.CreateDirectory(path);
                    print("Directory: " + cmd[2] + " created successfully.");
                }
                else
                {
                    print(cmd[2] + " failed to be created.");
                }
            }
            else if (cmd[0].ToLower() == "delete")
            {
                var path = Path.Combine(currentDirectory.FullName, cmd[2]);

                if (cmd.Length < 3)
                {
                    print("Usage: " + "delete <file/directory> <name>");
                }

                if (cmd[1].ToLower() == "file")
                {
                    if (File.Exists(path))
                    {
                        File.Delete(path);
                        print("File: " + cmd[2] + " deleted successfully.");
                    }
                    else
                    {

                        print("File: " + cmd[2] + " does not exist.");
                    }
                }
                else if (cmd[1].ToLower() == "directory")
                {
                    if (Directory.Exists(path))
                    {
                        Directory.Delete(path, true);
                        print("Directory: " + cmd[2] + " deleted successfully.");
                    }
                    else
                    {
                        print("Directory: " + cmd[2] + " does not exist.");
                    }
                }
                else
                {
                    print("Unknown Command: " + cmd[0]);

                }
            }
        }
    }
}
