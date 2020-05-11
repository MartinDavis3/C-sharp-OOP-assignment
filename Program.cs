using System;

namespace C__OOP_assignment
{
  class Program
  {
    class Painting {
      //Class with four properties and one abstract method, describe.
      private string name;
      public string Name {
        get {
          return name;
        } set {
          name = value;
        }
      }
      private string painter;
      public string Painter {
        get {
          return painter;
        } set {
          painter = value;
        }
      }
      private string medium;
      public string Medium {
        get {
          return medium;
        } set {
          medium = value;
        }
      }
      private int year;
      public int Year {
        get {
          return year;
        } set {
          year = value;
        }
      }
      public virtual string describe() {
        return "";
      }
    }
    class OilPainting : Painting {
      //Use auto-implemented property to set medium to read-only value of "oil" in this class
      //and hide the property of the base, painting, class.
      public new string Medium {get;} = "oil";
      private string support;
      public string Support {
        get {
          return support;
        } set {
          support = value;
        }
      }
      public override string describe() {
        return $"{this.Name} by {this.Painter}, oil on {this.Support}, {this.Year}.";
      }
    }
    static void Main(string[] args)
    {
        OilPainting monaLisa = new OilPainting();
        monaLisa.Name = "Mona Lisa";
        monaLisa.Painter = "Leonardo da Vinci";
        //The following line will give an error if uncommented. Medium is read-only for this class.
        //monaLisa.Medium = "Oil";
        monaLisa.Year = 1503;
        monaLisa.Support = "canvas";
        Console.WriteLine( monaLisa.describe());
        //The medium can be read.
        Console.WriteLine( monaLisa.Medium);
    }
  }
}
