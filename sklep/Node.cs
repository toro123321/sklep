using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sklep
{/*
    class Node
    {
        private static int counter = 0;
        public Node() { id_produktu = counter++; }
        public int id_produktu;
        public int liczba_porzadkowa;
    }
    */
    class Node
    {
        private static int counter = 0;

        public int ID = counter++;
        public string name;
        public int number;

        public Node(int numberC)
        {
            name = "kupa";
            number = numberC;
        }
    }

}


