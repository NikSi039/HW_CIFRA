using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW_23._07._17_Auto
{
    internal class Autom
    {
        private string? marka;
        private float volume;
        private float rasxod;

        public Autom(string marka, float volume, float rasxod)
        {
            this.marka = marka;
            this.volume = volume;
            this.rasxod = rasxod;
        }

        public void AddFuel(float f)
        {
            volume += f;
        }

        public void Go(float km)
        {
             volume -= (km * rasxod / 100);
        }

        public float Total()
        {
            return (volume / rasxod) * 100;
        }

        public void Print()
        {
            Console.WriteLine($"{volume}");
        }

        ~Autom()
        {
            marka = null;
        }
    }
}
