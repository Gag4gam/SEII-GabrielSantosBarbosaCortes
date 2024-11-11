string [] myarray = new string[5];
myarray[0] = "seg";
myarray[1] = "ter";
myarray[2] = "quart";
myarray[3] = "quinta";
myarray[4] = "sexta";
for(int i=0;i<5;i++){
Console.WriteLine(myarray[i]);

}
List <string> list = new List<string>();
list.Add("seg");
list.Add("ter");
list.Add("qua");
list.Add("qui");
list.Add("sex");
for(int i=0;i<list.Count;i++){
list[i]=list[i].Substring(0,2);
Console.WriteLine(list[i]);

}
Dictionary<int,string> dictionary = new Dictionary<int,string>();
dictionary[0] = "seg";
dictionary[1] = "ter";
dictionary[2] = "quart";
dictionary[3] = "quinta";
dictionary[4] = "sexta";

for(int i=0;i<dictionary.Count;i++){
Console.WriteLine(myarray[i]);

}