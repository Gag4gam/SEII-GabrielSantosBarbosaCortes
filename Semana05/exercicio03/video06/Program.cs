
    class Program{

        static void Main(){
            for (int i = 0; i < Environment.ProcessorCount; i++)
            {
                var thread = new Thread(escrever);
                thread.IsBackground = true;
                thread.Start();
            }
            
            
        }

    
    static void escrever(){

        System.Console.WriteLine("trhead");
    }


}
