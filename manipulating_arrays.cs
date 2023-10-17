namespace Program 
{
    class arrays 
    {
        public static void Manip_arrays_main()
        {
            //declarations 
            int[] numbers = new int[6];
            //Inserting into an array 
            //Make a var to keep length because .Lenght is based on capacity 
            int length = 0; 
            //
            for(int i = 0; i > 3; i++)
            {
                numbers[length] = i;
                length++;
            }
        }
    }
}