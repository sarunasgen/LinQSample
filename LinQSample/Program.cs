



using LinQSample;

List<Zmogus> zmogusList = new List<Zmogus>();

zmogusList.Add(new Zmogus { Amzius = 18, AsmensKodas = 3864324763, VardasPavarde = "Jonas Jonaitis"});
zmogusList.Add(new Zmogus { Amzius = 20, AsmensKodas = 3864324763, VardasPavarde = "Vaidas Jonaitis"});
zmogusList.Add(new Zmogus { Amzius = 53, AsmensKodas = 3864324763, VardasPavarde = "Petras Jonaitis"});
zmogusList.Add(new Zmogus { Amzius = 24, AsmensKodas = 3864324763, VardasPavarde = "Vardas Jonaitis"});
zmogusList.Add(new Zmogus { Amzius = 23, AsmensKodas = 3864324763, VardasPavarde = "Jonas Jonaitis"});
zmogusList.Add(new Zmogus { Amzius = 45, AsmensKodas = 3864324763, VardasPavarde = "Jonas Jonaitis"});
zmogusList.Add(new Zmogus { Amzius = 12, AsmensKodas = 3864324763, VardasPavarde = "Jonas Jonaitis"});
zmogusList.Add(new Zmogus { Amzius = 76, AsmensKodas = 3864324763, VardasPavarde = "Jonas Jonaitis"});
zmogusList.Add(new Zmogus { Amzius = 45, AsmensKodas = 3864324763, VardasPavarde = "Jonas Jonaitis"});

//Raw LINQ užklausa
var linqResult = from z in zmogusList 
                 where z.VardasPavarde.Contains("P") 
                 select z;
//Syntax method užklausa
var linqSyntaxMethod = zmogusList.Where(x => x.VardasPavarde.Contains("P"));

var list = linqResult.ToList();
var syntaxList = linqSyntaxMethod.ToList();

bool isTheSame = list.SequenceEqual(syntaxList);

var zmoniuSarasasRaw = (from z in zmogusList
                    where z.Amzius > 12 && z.Amzius < 23
                    select z.VardasPavarde).ToList();

var zmoniuSarasasSyntax = zmogusList.Where(x => x.Amzius > 12 && x.Amzius < 23).Select(x => x.VardasPavarde).ToList();



Dictionary<int, Zmogus> dictionarySample = new Dictionary<int, Zmogus>();

dictionarySample.Add(5, new Zmogus { Amzius = 20, AsmensKodas = 3864324763, VardasPavarde = "Vaidas Jonaitis"});
dictionarySample.Add(73, new Zmogus { Amzius = 23, AsmensKodas = 3864324763, VardasPavarde = "Jonas Jonaitis" });
dictionarySample.Add(58, new Zmogus { Amzius = 53, AsmensKodas = 3864324763, VardasPavarde = "Petras Jonaitis" });


string value = Translation("lt", "login");

int c = 0;


string Translation(string locale, string translationkey)
{
    var translations_EN = new Dictionary<string, string>();

    translations_EN.Add("login", "Login");
    translations_EN.Add("logout", "Log Out");

    var translations_LT = new Dictionary<string, string>();

    translations_LT.Add("login", "Prisijungti");
    translations_LT.Add("logout", "Atsijungti");

    Dictionary<string, string> translations = new Dictionary<string, string>();

    if(locale == "en")
    {
        translations = translations_EN;
    }
    else
        translations = translations_LT;



    return translations.GetValueOrDefault(translationkey);
}


List<Student> students = new List<Student>();

students.Add(new Student { Age = 43, AvarageMark = 8.55, Id = 1, IsGettingTuition = true, Name = "Jonas" });
students.Add(new Student { Age = 32, AvarageMark = 6.99, Id = 2, IsGettingTuition = false, Name = "Vaidas" });
students.Add(new Student { Age = 12, AvarageMark = 9.59, Id = 3, IsGettingTuition = false, Name = "Vardaitis" });
students.Add(new Student { Age = 23, AvarageMark = 9.59, Id = 4, IsGettingTuition = false, Name = "Giedrius" });
students.Add(new Student { Age = 18, AvarageMark = 8.89, Id = 5, IsGettingTuition = true, Name = "Greta" });
students.Add(new Student { Age = 16, AvarageMark = 3.89, Id = 5, IsGettingTuition = true, Name = "Regina" });
students.Add(new Student { Age = 18, AvarageMark = 4.89, Id = 5, IsGettingTuition = true, Name = "Gintare" });


var galintysVartotiAlko = students.Where(x=> x.Age > 20).ToArray();

var gaunantysValstybesParamaSu8Plus = (from s in students
                                       where s.IsGettingTuition && s.AvarageMark > 8
                                       select s).ToArray();

var zemiau4IrMaziau8 = students.Where(studentas => studentas.AvarageMark < 4 && studentas.Name.Count() <= 8).ToArray();

var masyvasId = gaunantysValstybesParamaSu8Plus.Select(x => x.Id).ToArray();

var masyvasId4Maziau = zemiau4IrMaziau8.Select(x => x.Id).ToArray();

c = c;