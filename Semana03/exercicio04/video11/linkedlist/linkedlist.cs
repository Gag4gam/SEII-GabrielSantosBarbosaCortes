using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
namespace video06.linkedlist
{
    public class linkedlist
    {
        node First {get;set;}
        public void insertFirst(int data){
                node newnode = new node();
                newnode.Data = data;
                newnode.Next = First;
                First = newnode;


        }

        public node deleteFirst(){
            node temp = First;
            First = First.Next;
            return temp;
        }

        public void displayList(){
            Console.WriteLine("iterando...");
            node current = First;
            while(current!=null){
                current.displayNode();
                current=current.Next;
            }

        }

        public void insertLast(int data){
            node current = First;
            while(current!=null){
                
                current=current.Next;
            }

            node newnode = new node();
            newnode.Data = data;
            newnode.Next = newnode;
            

        }
    }
}