private double saldo;

public double GetSaldo() //Get - buscar
{
    return this.saldo;
}
public void Set.saldo; //Set - alterar
{
    this.saldo = saldo;
}

// this vem junto com o atributo que foi instanciado (esse(this) objeto atual)
// e do outro lado é o parametro da função - lado direito

// em C#

class Conta
{
    private double saldo;

    public double Saldo
    {
        get{ return saldo;}
        set{saldo = value;}
    }
}

//encapsulamento é usar private e set e get para os atributos
