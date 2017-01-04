using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sklep
{
    class Program
    {
        static void Main(string[] args)
        {

            List<List<Node>> tree = new List<List<Node>>
            {
                new List<Node>() {new Node(1),new Node(1),new Node(1),new Node(0),new Node(6),new Node(0),new Node(0),new Node(0),new Node(0),new Node(-1)},
                new List<Node>() {new Node(0),new Node(0),new Node(0),new Node(0),new Node(0),new Node(0),new Node(9),new Node(9),new Node(0),new Node(-1)},
                new List<Node>() {new Node(2),new Node(2),new Node(2),new Node(0),new Node(7),new Node(0),new Node(0),new Node(0),new Node(0),new Node(0)},
                new List<Node>() {new Node(3),new Node(3),new Node(3),new Node(0),new Node(7),new Node(0),new Node(10),new Node(10),new Node(0),new Node(0)},
                new List<Node>() {new Node(0),new Node(0),new Node(0),new Node(0),new Node(0),new Node(0),new Node(0),new Node(0),new Node(0),new Node(0)},
                new List<Node>() {new Node(4),new Node(4),new Node(4),new Node(0),new Node(8),new Node(0),new Node(11),new Node(11),new Node(0),new Node(-2)},
                new List<Node>() {new Node(5),new Node(5),new Node(5),new Node(0),new Node(8),new Node(0),new Node(0),new Node(0),new Node(0),new Node(-2)},
                new List<Node>() {new Node(0),new Node(0),new Node(0),new Node(0),new Node(8),new Node(0),new Node(12),new Node(12),new Node(0),new Node(-2)},
            };



        }
    }
}
