using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * KOMPOZIT - OBRASCI STRUKTURE
 * 
 * Component - Component
 * File      - Leaf
 * Directory - Composite
 */

namespace SestaZadacaEdukos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Component file1 = new File("file1.txt", 1024);
            Component file2 = new File("file2.txt", 2048);

            Directory directory1 = new Directory("Folder 1");

            directory1.AddComponent(file1);
            directory1.AddComponent(file2);

            file1.DisplayInfo();
            directory1.DisplayInfo();
        }
    }
    public abstract class Component
    {
        public abstract void DisplayInfo();
        
    }
    public class File : Component
    {
        private string fileName;
        private int fileSize;

        public File(string name, int size)
        {
            fileName = name;
            fileSize = size;
        }

        public override void DisplayInfo()
        {
                Console.WriteLine($"File: {fileName}, Size: {fileSize} bytes");
        }
    }
    public class Directory : Component
    {
        private string directoryName;
        private List<Component> components = new List<Component>();

        public Directory(string name)
        {
            directoryName = name;
        }

        public void AddComponent(Component component)
        {
            components.Add(component);
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Directory: {directoryName}");
            foreach (var component in components)
            {
                component.DisplayInfo();
            }
        }
    }
}
