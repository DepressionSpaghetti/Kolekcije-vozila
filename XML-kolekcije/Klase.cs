using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XML_kolekcije
{
    class Vozilo
    {
        string model, kategorija;
        int brKotaca;
        long godina;

        public Vozilo(string model, string kategorija, int brKotaca, long godina)
        {
            this.model = model;
            this.kategorija = kategorija;
            this.brKotaca = brKotaca;
            this.godina = godina;
        }

        string Model { get => model; set => model = value; }
        string Kategorija { get => kategorija; set => kategorija = value; }
        int BrKotaca { get => brKotaca; set => brKotaca = value; }
        long Godina { get => godina; set => godina = value; }

    }
    class Motocikl : Vozilo
    {
        public Motocikl(string model, string kategorija, int brKotaca, long godina) : base(model, kategorija,brKotaca, godina)
        {
            kategorija = "Motocikl";
        }
    }
    class Automobil : Vozilo
    {
        public Automobil(string model, string kategorija, int brKotaca, long godina) : base(model, kategorija, brKotaca, godina)
        {
            kategorija = "Automobil";
        }

    }
    class Kamion : Vozilo
    {
        public Kamion(string model, string kategorija, int brKotaca, long godina) : base(model, kategorija, brKotaca, godina)
        {
            kategorija = "Kamion";
        }
    }
}