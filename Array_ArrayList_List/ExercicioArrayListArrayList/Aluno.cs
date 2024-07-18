using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioArrayListArrayList;

public class Aluno
{
    public string[] alunos = new string[10];

    public string this[int i]
    {
        get
        {
            return String.IsNullOrEmpty(alunos[i]) ? "Error" : alunos[i];
        }
        set
        {
            if (alunos[i] != "")
            {
                alunos[i] = value;
            }
            else
            {
                alunos[i] = "Error";
            }
        }
    }


}