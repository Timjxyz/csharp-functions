//void StampaArray(int[] array): che preso un array di numeri interi, stampa a
//video il contenuto dell’array in questa forma “[elemento 1, elemento 2, elemento 3, ...]“.
//Potete prendere quella fatta in classe questa mattina


int[] array = { 10, 14, 2, 62, 54 };
//StampaArray(array);

//int numero = 6;
//Console.WriteLine("Il quadrato di 6 è: "+Quadrato (numero));

//Console.WriteLine("La somma è: " + sommaElementiArray(array));

int[] arrayElevato=ElevaArrayAlQuadrato(array);

//StampaArray(array);

//StampaArray(arrayElevato);

Console.WriteLine("La somma è:" + sommaElementiArray(arrayElevato));

void StampaArray(int[] array)
{
    for(int i =0; i < array.Length; i++){
        if (i == 0)
        {
            Console.Write($"[{array[i]},");

        }else if(i == array.Length - 1)
        {
            Console.Write($"{array[i]}]");
        }
        else
        {
            Console.Write($"{array[i]},");
        }
    }    
}

//int Quadrato(int numero): che vi restituisca il quadrato del numero passato come parametro.


int Quadrato(int numero){
    return numero * numero ;
}

//int[] ElevaArrayAlQuadrato(int[] array): che preso un array di numeri interi,
//restituisca un nuovo array con tutti gli elementi elevati quadrato.
//Attenzione: è importante restituire un nuovo array, e non modificare l’array come parametro della funzione!
//Vi ricordate perchè? Pensateci (vedi slide)

int[] ElevaArrayAlQuadrato(int[] array)
{
    int[] nuovoArray=(int[])array.Clone();

    for(int i = 0; i < nuovoArray.Length; i++)
    {
        nuovoArray[i]*=array[i];
    }  
    return nuovoArray;
}

//int sommaElementiArray(int[] array): che preso un array di numeri interi, restituisca la somma totale
//di tutti gli elementi dell’array.

int sommaElementiArray(int[] array)
{
    int somma = 0;
    for(int i=0; i < array.Length; i++)
    {
        somma+=array[i];
    }
    return somma;
}