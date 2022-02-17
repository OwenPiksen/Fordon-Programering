using System;
// class Fordon
// {

//     public Fordon(string tillverkare,string modell,int årsmodell) {
//         Tillverkare=tillverkare;
//         Modell=modell;
//         Årsmodell=årsmodell;
//     }
//     public string Tillverkare{set; get;}

//     public string Modell{set; get;}

//     public int Årsmodell{set; get;}

//     public override string ToString()
//     {
//         return (Tillverkare+" "+Modell+" "+Årsmodell);
//     }
// }
class Fordon : IComparable<Fordon>
{
    public string Tillverkare { get; set;}

    public string Modell { get; set;}

    public int Årsmodell { get; set;}


    public Fordon(
        string tillverkare, 
        string modell, 
        int årsmodell)

    {
        Tillverkare = tillverkare;
        Modell = modell;
        Årsmodell = årsmodell;
    }

    public int CompareTo(Fordon annatfordon)
    {
        int returnfordon;

        if (this.Årsmodell > annatfordon.Årsmodell)
            returnfordon = 1;
        else
            if (this.Årsmodell < annatfordon.Årsmodell)
            returnfordon = -1;
        else
            returnfordon = 0;
        
        return returnfordon;
    }
    public string ToString(){
        return Tillverkare + ' ' + Årsmodell + ' ' + Modell;
    }
}
