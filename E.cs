using  System;
class E
{
    public static int Oran(int N)
    {
        int k=1;
        for(int i = 2; i<=N; i++)
        {
            k*=i;  
        }
        
        return k;
    }
}