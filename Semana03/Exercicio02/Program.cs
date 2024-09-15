string[] myArray = new string[7];
myArray[0] = "segunda";
myArray[1] = "terça";
myArray[2] = "quarta";
myArray[3] = "quinta";
myArray[4] = "sexta";
myArray[5] = "sabado";
myArray[6] = "domingo";

for (int i = 0; i< myArray.Length; i++)
{
    Console.WriteLine(myArray[i]);
}

List<string> lista = new List<string>();
lista.Add("segunda");
lista.Add("terça");
lista.Add("quarta");
lista.Add("quinta");
lista.Add("sexta");
lista.Add("sabado");
lista.Add ("domingo");

for (int i = 0; i< lista.Count; i++)
{
    Console.WriteLine(lista[i]);
}

for (int i = 0; i< lista.Count; i++)
{
    lista[i]= lista[i].Substring(0, 3);
    Console.WriteLine(lista[i]);
}

Dictionary<int, string> dictionario = new Dictionary<int, string>();
dictionario[0] = "segunda";
dictionario[1] = "terça";
dictionario[2] = "quarta";
dictionario[3] = "quinta";
dictionario[4] = "sexta";
//dictionario[5] = "sabado";
dictionario.Add(5, "sabado");
dictionario[6] = "domingo";

for (int i = 0; i< dictionario.Count; i++)
{
    dictionario[i]= dictionario[i].Substring(0, 3);
    Console.WriteLine(dictionario[i]);
}