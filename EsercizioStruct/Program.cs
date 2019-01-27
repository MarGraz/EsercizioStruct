using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsercizioStruct
{
    class Program
    {
        static void Main(string[] args)
        {
            //inizializzo oggetto MyClass e lo valorizzo
            MyClass classe = new MyClass();
            classe.myString = "Marco";
            classe.myInteger = 1;

            //inizializzo oggetto MyStruct e lo valorizzo
            MyStruct struttura = new MyStruct();
            struttura.myString = "Andrea";
            struttura.myInteger = 2;

            Console.WriteLine("Prima Classe: " + classe.myString + " - " + classe.myInteger);
            Console.WriteLine("Prima Struttura: " + struttura.myString + " - " + struttura.myInteger);
            Console.WriteLine("Premi invio per continuare... ");
            Console.ReadLine();

            Console.WriteLine("Il metodo proverà ad assegnare sia alla classe che alla struct i nuovi valori: Pippo, 3");
            Console.WriteLine("Premi invio per continuare... ");
            Console.ReadLine();

            //passo al metodo, la "classe", la "struttura", e "due nuovi valori". Ciò che accadrà è che per la struct, essendo trattata come tipo valore (value type), non vedrò cambiamenti, i valori rimarranno quelli inizializzati qui sopra, perché al metodo "ClassMethod" l'oggetto "struttura" viene passato PER RIFERIMENTO
            ClassMethod(classe, struttura, 3, "Pippo");

            Console.WriteLine("Dopo Classe: " + classe.myString + " - " + classe.myInteger);
            Console.WriteLine("Dopo Struttura: " + struttura.myString + " - " + struttura.myInteger);
            Console.WriteLine("Premi invio per terminare... ");
            Console.ReadLine();
        }

        public static void ClassMethod(MyClass mclass, MyStruct mStruct, int intValue, string strValue)
        {
            //assegno al MyInteger della CLASSE il valore di INTERO
            mclass.myInteger = intValue;
            //assegno al MyInteger della CLASSE il valore di STRINGA
            mclass.myString = strValue;

            //assegno al MyInteger della STRUTTURA il valore di INTERO
            mStruct.myInteger = intValue;
            //assegno al MyInteger della STRUTTURA il valore di STRINGA
            mStruct.myString = strValue;
        }
    }


    public class MyClass
    {
        public string myString;
        public int myInteger;
    }

    public struct MyStruct
    {
        public string myString;
        public int myInteger;
    }

}
