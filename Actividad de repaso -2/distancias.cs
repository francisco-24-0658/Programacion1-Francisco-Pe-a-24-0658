using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;
using System.Reflection.Metadata.Ecma335;


class Rutas
{

public double PuertoPlata;

public double Santiago;

public double PuntaCana;

public double Samana;


public Rutas(double PuertoPlata, double Santiago, double PuntaCana, double Samana) 
{
    this.PuertoPlata = PuertoPlata;
    this.Santiago = Santiago;
    this.PuntaCana = PuntaCana;
    this.Samana = Samana;
}


}