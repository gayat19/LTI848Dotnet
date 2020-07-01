using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverloadingExampleProject
{
    class IndexerOverloadExample
    {
        string[] names;
        public IndexerOverloadExample()
        {
            names = new string[5];
        }
        public string this[int index]
        {
            get { return names[index]; }
            set { names[index] = value; }
        }
        public int this[string txt]//overloaded the indexer
        {
            get {
                int idx = -1;
                for (int i = 0; i < names.Length; i++)
                {
                    if(txt == names[i])
                    {
                        idx = i;
                        break;
                    }
                }
                return idx;
            }
           
        }
    }
    class CallIndexerClass 
    {
        static void Main(string[] args)
        {
            IndexerOverloadExample example = new IndexerOverloadExample();
            example[0] = "Hi";
            example[1] = "Hello";
            example[2] = "Welcome";
            example[3] = "Bye";
            example[4] = "Gone..";
            Console.WriteLine("The index of 'igjasas' is "+example["igjasas"]);
            Console.ReadKey();
        }
    }
}
