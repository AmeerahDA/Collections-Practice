// See https://aka.ms/new-console-template for more information

//Create an array to hold integer values 0 through 9
int[] numArray = new int[10];
int i = 0;
foreach (int ind in numArray)
{
    numArray[ind]= i;
    i++;
    Console.Write(numArray[ind]+" ");
}

Console.WriteLine("");
Console.WriteLine("-------------");
//Create an array of the names "Tim", "Martin", "Nikki", & "Sara"
String[] Names = new String[]{"Tim","Martin","Nikki","Sara"};
foreach(String name in Names){
Console.Write(name+" ");
}

Console.WriteLine("");
Console.WriteLine("-------------");
//Create an array of length 10 that alternates between true and false values, starting with true
bool[] x = new bool[10];
int z=0;
while(z<10){
    if(z%2==0){
        x[z]=true;
    }else{
        x[z]=false;
    }
Console.Write(x[z]+" ");
z++;
}

Console.WriteLine("");
Console.WriteLine("-------------");
//List of Flavors
List<string> IceCream = new List<string>();
IceCream.Add("Vanilla");
IceCream.Add("Chocolate");
IceCream.Add("Toffee");
IceCream.Add("Chocolate chips");
IceCream.Add("Cookies");
IceCream.Add("Oreo");
Console.WriteLine("The length of list is "+IceCream.Count);
Console.WriteLine("The third flavor in the list is "+IceCream[2]);
IceCream.Remove("Toffee");
Console.WriteLine("The length of list is "+IceCream.Count);

Console.WriteLine("");
Console.WriteLine("-------------");
//User Info Dictionary
Dictionary<string,string> dic = new Dictionary<string,string>();
 Random rnd = new Random();
 int index ;
for(int d=0;d<=Names.Length-1;d++){
     index = rnd.Next(IceCream.Count);
    dic.Add( Names[d],IceCream[index]);
}
foreach (var entry in dic)
{
    Console.WriteLine(entry.Key + " - " + entry.Value);
}
