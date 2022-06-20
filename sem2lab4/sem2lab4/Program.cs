using System;

namespace sem2lab4
{

    abstract class Disk
    {
        protected static int DirectorySize { get; set; }
        public static int FileCount { get; set; }
        public abstract int Size { get; set; }
        public abstract void Start();
       
    }

    class Directory : Disk
    {
       
        public override int Size { get; set; }
        public Directory() { }
        public Directory(int size)
        {
            this.Size = size;   
            
        }

        public override void Start() { Console.WriteLine("Directory is opened"); }
        public void GetObjType(object obj)
        {
           Console.WriteLine($"This object type is {obj.GetType().Name}");
        }
        public void GetMP3Count()
        {
            Console.WriteLine($"There are {FileCount} .mp3 files int the Directory");
        }
        public void GetDirectorySize()
        {
            Console.WriteLine($"There directory size is {DirectorySize} bites");
        }

    }
     class File: Directory
    {
        public override void Start() { Console.WriteLine("File is opened"); }
        public File(int size) : base(size)
        {
            this.Size = size;
            DirectorySize += size;     
                }
       
    }
    class Archive : Directory
    {
        public override void Start() { Console.WriteLine("Archive is opened"); }
        public Archive (int size) : base(size)
        {
            this.Size = size;
            DirectorySize += size;

        }
    }
    class MP3 : Directory
    {
        public override void Start() { Console.WriteLine("Mp3 is opened"); }
        public MP3(int size) : base(size)
        {
            this.Size = size;
            DirectorySize += size;
            FileCount++;
        }
    }

    
    class Program
    {
      
        static void Main(string[] args)
        {
            Directory dir = new Directory();
            MP3 Mp32 = new MP3(5);
            MP3 Mp33 = new MP3(5);
            Directory File = new File(10);
         
            dir.GetDirectorySize();
            dir.GetMP3Count();
            dir.GetObjType(Mp32);

            File.Start();
          
        }
    }
}
