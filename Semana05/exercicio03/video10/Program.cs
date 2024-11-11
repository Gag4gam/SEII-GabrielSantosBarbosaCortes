
    class Program{

        static void Main(){
            var thread = new Thread(escrever);
            thread.Start();
            thread.Join();
        }

    
    static void escrever(){

        System.Console.WriteLine("Hello World");
    }


}
