using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace video06.linkedlist
{
    public class node
    {
        public int Data {get;set;}

        public node? Next {get;set;}

        public void displayNode(){
            Console.WriteLine(Data);


        }
    }
}