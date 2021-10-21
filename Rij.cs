using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static TeDoen.Form1;

namespace TeDoen
{
    internal class Rij<T>
    {
        List<T> teDoenLijst = new List<T>();
        private static int teller;
        public event Tonen toon;

        public void toevoegenInRij(T toevoegen)
        {
            teDoenLijst.Add(toevoegen);
        }

        public T verwijderenInRij()
        {
            if (teDoenLijst.Count == 0)
                throw new StackOverflowException();
            T plaats = teDoenLijst[0];
            teDoenLijst.RemoveAt(0);
            return plaats;
        }

        public T Toon()
        {
            if (teDoenLijst.Count == 0)
                throw new StackOverflowException();
            T plaats = teDoenLijst[0];
            teDoenLijst.Contains(plaats);
            return plaats;
        }

        public void leegmakenRij()
        {
            if (teDoenLijst.Count == 0)
                throw new StackOverflowException();
            teDoenLijst.Clear();
        }

        public override string ToString()
        {
            return String.Join(" / ", teDoenLijst);
        }

        public bool isEmpty()
        {
            if (teDoenLijst.Count == 0)
                return true;
            else
                return false;
        }

        public List<T> Copy(List<T> copy)
        {
            List<T> teDoenLijst2 = new List<T>();
            foreach (T toevoegen in copy)
            {
                teDoenLijst2.Add(toevoegen);
            }
            return teDoenLijst2;
        }

        public void achteraanInRij()
        {
            if (teDoenLijst.Count <= 0)
            {
                throw new StackOverflowException();
            }
            T plaats = teDoenLijst[teller - 1];
            teDoenLijst.RemoveAt(teller - 1);
            teDoenLijst.Add(plaats);
            teller--;

            methodeTonen(plaats);
        }

        public void methodeTonen(object te)
        {
            if (toon != null)
            {
                toon(te);
            }
        }
    }
}
