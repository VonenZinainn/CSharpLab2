namespace Part1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            ExcellentPupil Bob = new ExcellentPupil("Bob");
            GoodPupil Mike = new GoodPupil("Mike");
            BadPupil John = new BadPupil("John");
            GoodPupil Daniel = new GoodPupil("Daniel");
            ClassRoom classRoom = new ClassRoom(Bob, Mike, Daniel, John);

            classRoom.PupilsStudy();
            classRoom.PupilsRead();
            classRoom.PupilsWrite();
            classRoom.PupilsRelax();
        }
    }

    public class ClassRoom
    {
        public Pupil Pupil1 { get; set; }
        public Pupil Pupil2 { get; set; }
        public Pupil Pupil3 { get; set; }
        public Pupil Pupil4 { get; set; }

        public ClassRoom(Pupil pupil1, Pupil pupil2)
        {
            Pupil1 = pupil1;
            Pupil2 = pupil2;
            Pupil3 = new Pupil();
            Pupil4 = new Pupil();
        }

        public ClassRoom(Pupil pupil1, Pupil pupil2, Pupil pupil3)
        {
            Pupil1 = pupil1;
            Pupil2 = pupil2;
            Pupil3 = pupil3;
            Pupil4 = new Pupil();
        }


        public ClassRoom(Pupil pupil1, Pupil pupil2, Pupil pupil3, Pupil pupil4)
            => (Pupil1, Pupil2, Pupil3, Pupil4) = (pupil1, pupil2, pupil3, pupil4);

        public void PupilsStudy()
        {
            Pupil1.Study();
            Pupil2.Study();
            Pupil3.Study();
            Pupil4.Study();
        }

        public void PupilsRead()
        {
            Pupil1.Read();
            Pupil2.Read();
            Pupil3.Read();
            Pupil4.Read();
        }

        public void PupilsWrite()
        {
            Pupil1.Write();
            Pupil2.Write();
            Pupil3.Write();
            Pupil4.Write();
        }

        public void PupilsRelax()
        {
            Pupil1.Relax();
            Pupil2.Relax();
            Pupil3.Relax();
            Pupil4.Relax();
        }
    }

    public class Pupil
    {
        public string Name { get; set; }
        public Pupil() => Name = "Undefined";
        public Pupil(string name) => Name = name;

        public virtual void Study()
        {
        }

        public virtual void Read()
        {
        }

        public virtual void Write()
        {
        }

        public virtual void Relax()
        {
        }
    }

    public class ExcellentPupil : Pupil
    {
        public ExcellentPupil() : base()
        {
        }

        public ExcellentPupil(string name) : base(name)
        {
        }

        public override void Study()
        {
            Console.WriteLine($"{Name} is studying hard.");
        }

        public override void Read()
        {
            Console.WriteLine($"{Name} is reading effectively.");
        }

        public override void Write()
        {
            Console.WriteLine($"{Name} is writing fast and carefully.");
        }

        public override void Relax()
        {
            Console.WriteLine($"{Name} has changed his activity to have a rest.");
        }
    }

    public class GoodPupil : Pupil
    {
        public GoodPupil() : base()
        {
        }

        public GoodPupil(string name) : base(name)
        {
        }

        public override void Study()
        {
            Console.WriteLine($"{Name} is studying nearly hard enough.");
        }

        public override void Write()
        {
            Console.WriteLine($"{Name} is writing fast but not accurate enough.");
        }

        public override void Read()
        {
            Console.WriteLine($"{Name} is reading nearly effective.");
        }

        public override void Relax()
        {
            Console.WriteLine($"{Name} is relaxed after the work is done.");
        }
    }

    public class BadPupil : Pupil
    {
        public BadPupil() : base()
        {
        }

        public BadPupil(string name) : base(name)
        {
        }

        public override void Study()
        {
            Console.WriteLine($"{Name} is copying his work instead of doing it.");
        }

        public override void Write()
        {
            Console.WriteLine($"{Name} is sleeping instead of writing.");
        }

        public override void Read()
        {
            Console.WriteLine($"{Name} is reading only first and last paragraphs.");
        }

        public override void Relax()
        {
            Console.WriteLine($"{Name} is always relaxed.");
        }
    }
}