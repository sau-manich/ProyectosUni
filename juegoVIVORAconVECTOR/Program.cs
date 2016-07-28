using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace viborita
{

    class Program
    {
        int contLanzado = 0;

        static void Main(string[] args)
        {
            int dadoLanzado = 0;
            Program program = new Program();
            program.menuInicio();
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("      seleccione una opccion");
            string opcion = Console.ReadLine();

            if (opcion.Equals("1"))
            {
                Console.Clear();

                program.menuNivel();
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("      ingrese nivel de dificultad");
                string opcionNivel = Console.ReadLine();
                Console.Clear();
                switch (opcionNivel)
                {
                    case "1":
                        for (int i = 0; i < 100; i++)
                        {
                            if (program.contLanzado < 60)
                            {
                                dadoLanzado = program.lanzar();
                                program.contLanzado = program.contLanzado + dadoLanzado;
                                if (program.contLanzado > 60)
                                {
                                    int rebote = program.contLanzado - 60;
                                    program.contLanzado = (program.contLanzado - (rebote * 2));
                                }
                                program.menuVivora(dadoLanzado, program.contLanzado);
                                program.preguntasFacil();
                                Console.ReadKey(true);

                                Console.Clear();
                            }
                            else
                            {
                                Console.WriteLine("");
                                Console.WriteLine("");
                                Console.WriteLine("");
                                Console.WriteLine("");
                                Console.WriteLine("");
                                Console.WriteLine("");
                                Console.WriteLine("");
                                Console.WriteLine("");
                                Console.WriteLine("                   G---A---M---E......O---V---E---R    ");
                                i = 100;
                            }
                        }
                        break;
                    case "2":
                        for (int i = 0; i < 100; i++)
                        {
                            if (program.contLanzado < 60)
                            {
                                dadoLanzado = program.lanzar();
                                program.contLanzado = program.contLanzado + dadoLanzado;
                                if (program.contLanzado > 60)
                                {
                                    int rebote = program.contLanzado - 60;
                                    program.contLanzado = (program.contLanzado - (rebote * 2));
                                }
                                program.menuVivora(dadoLanzado, program.contLanzado);
                                program.preguntasFacil();
                                Console.ReadKey(true);

                                Console.Clear();
                            }
                            else
                            {
                                Console.WriteLine("");
                                Console.WriteLine("");
                                Console.WriteLine("");
                                Console.WriteLine("");
                                Console.WriteLine("");
                                Console.WriteLine("");
                                Console.WriteLine("");
                                Console.WriteLine("");
                                Console.WriteLine("                   G---A---M---E......O---V---E---R    ");
                                i = 100;
                            }
                        }
                        break;
                    case "3":
                        for (int i = 0; i < 100; i++)
                        {
                            if (program.contLanzado < 60)
                            {
                                dadoLanzado = program.lanzar();
                                program.contLanzado = program.contLanzado + dadoLanzado;
                                if (program.contLanzado > 60)
                                {
                                    int rebote = program.contLanzado - 60;
                                    program.contLanzado = (program.contLanzado - (rebote * 2));
                                }
                                program.menuVivora(dadoLanzado, program.contLanzado);
                                program.preguntasFacil();
                                Console.ReadKey(true);

                                Console.Clear();
                            }
                            else
                            {
                                Console.WriteLine("");
                                Console.WriteLine("");
                                Console.WriteLine("");
                                Console.WriteLine("");
                                Console.WriteLine("");
                                Console.WriteLine("");
                                Console.WriteLine("");
                                Console.WriteLine("");
                                Console.WriteLine("                   G---A---M---E......O---V---E---R    ");
                                i = 100;
                            }
                        }
                        break;
                    default:
                        break;
                }
            }
            Console.ReadKey();
        }
        public void menuVivora(int a, int b)
        {
            string[] v= new string[] { "01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31", "32", "33", "34", "35", "36","37", "37", "38", "39", "40", "41", "42", "43", "44", "45", "46", "47", "48", "49", "50", "51", "52", "53", "54", "55", "56", "57", "58", "59", "60"};

            for (int i = 0; i < v.Length; i++)
            {
                if (i<9)
                {
                     if (v[i]=="0"+b.ToString())
                    {
                        v[i]="**";
                        i = v.Length;
                    }
                }
                else
                {
                    if (v[i] == b.ToString())
                    {
                        v[i] = "**";
                        i = v.Length;
                    }
                }
            }
            Console.WriteLine(" ________________________________________________________");
            Console.WriteLine("|                                                        |");
            Console.WriteLine("|                                                        |                   ");
            Console.WriteLine("|          ____________________________________          |                   ");
            Console.WriteLine("|        /       |          |                O `.        |                   ");
            Console.WriteLine("|       /   " + v[59] + "   |    " + v[60] + "    |   FINAL     `._____:--<    |                   ");
            Console.WriteLine("|      |         |__________|___________________/        |                   ");
            Console.WriteLine("|      |---------<__________________________             |           ");
            Console.WriteLine("|      |    " + v[58] + "   |          |         /      `.          |         _________");
            Console.WriteLine("|       `.       |    " + v[57] + "    |   " + v[56] + "   /   " + v[55] + "    `.        |       /         /|");
            Console.WriteLine("|         `._____|__________|_______/           |        |      /_________/ |");
            Console.WriteLine("|         _________________________>----------- |        |     |         |  |   ");
            Console.WriteLine("|        /       |         |       `.    " + v[54] + "     /        |     |   ({0})   | /", a);
            Console.WriteLine("|       /    " + v[51] + "  |    " + v[52] + "   |    " + v[53] + "   `.        /         |     |_________|/    ");
            Console.WriteLine("|      |         |_________|___________`._____/          |");
            Console.WriteLine("|      |--------<____________________________            |");
            Console.WriteLine("|      |         |         |        /         `.         | SACASTE UN = {0} ", a);
            Console.WriteLine("|       `.   " + v[50] + "  |   " + v[49] + "    |   " + v[48] + "  /     " + v[47] + "     `.       | ABANZA {0} CASILLAS", a);
            Console.WriteLine("|         `._____|_________|______/              |       | POSICION ACTUAL = {0}", b);
            Console.WriteLine("|         _________________________>----------- |        |     ");
            Console.WriteLine("|        /       |         |       `.    " + v[46] + "     /        |     ");
            Console.WriteLine("|       /    " + v[43] + "  |    " + v[44] + "   |    " + v[45] + "");
            Console.WriteLine("|      |         |_________|___________`._____/          |");
            Console.WriteLine("|      |--------<____________________________            |");
            Console.WriteLine("|      |         |         |        /         `.         |");
            Console.WriteLine("|       `.   " + v[42] + "  |   " + v[41] + "    |   " + v[40] + "  /     " + v[39] + "|");
            Console.WriteLine("|         `._____|_________|______/______________|       |");
            Console.WriteLine("|                 |________|      |             |        |");
            Console.WriteLine("|                 /_______/ |     |      " + v[38] + "     |        |");
            Console.WriteLine("|                |________| |     |             |        |");
            Console.WriteLine("|               /________/| |     |_____________|        |");
            Console.WriteLine("|               |_______| | |     |             |        |");
            Console.WriteLine("|              /_______/| |_/     |    PIERDE   |        |");
            Console.WriteLine("|             |_______| | |       |   TU TURNO  |        |");
            Console.WriteLine("|            /_______/| |_/       |_____________|        |");
            Console.WriteLine("|            |______| | |         |             |        |");
            Console.WriteLine("|           /______/| |_/         |      "+ v[36] +"     |        |");
            Console.WriteLine("|          |______| | |           |             |        |");
            Console.WriteLine("|         /_______/_|_/___________|-------------|        |");
            Console.WriteLine("|        /       |         |       `.    " + v[35] + "     /        |");
            Console.WriteLine("|       /    " + v[32] + "  |    " + v[33] + "   |    " + v[34] + "   `.        /         |");
            Console.WriteLine("|      |         |_________|___________`._____/          |");
            Console.WriteLine("|      |--------<____________________________            |");
            Console.WriteLine("|      |         |         |        /         `.         |");
            Console.WriteLine("|       `.   " + v[31] + "  |   " + v[30] + "    |   " + v[29] + "  /     " + v[28] + "     `.       |");
            Console.WriteLine("|         `._____|_________|______/              |       |");
            Console.WriteLine("|         _________________________>----------- |        |");
            Console.WriteLine("|        /       |         |       `.    " + v[27] + "     /        |     ");
            Console.WriteLine("|       /    " + v[24] + "  |    " + v[25] + "   |    " + v[26] + "");
            Console.WriteLine("|      |         |_________|___________`._____/          |");
            Console.WriteLine("|      |--------<____________________________            |");
            Console.WriteLine("|      |         |         |        /         `.         |");
            Console.WriteLine("|       `.   " + v[23] + "  |   " + v[22] + "    |   " + v[21] + "  /     " + v[20] + "     `.       |");
            Console.WriteLine("|         `._____|_________|______/              |       |");
            Console.WriteLine("|         _________________________>----------- |        |      ");
            Console.WriteLine("|        /       |         |       `.    " + v[19] + "     /        |");
            Console.WriteLine("|       /    " + v[16] + "  |    " + v[17] + "   |    " + v[18] + "");
            Console.WriteLine("|      |         |_________|___________`._____/          |");
            Console.WriteLine("|      |--------<____________________________            |");
            Console.WriteLine("|      |         |         |        /         `.         |");
            Console.WriteLine("|       `.   " + v[15] + "  |   " + v[14] + "    |   " + v[13] + "  /     " + v[12] + "     `.       |");
            Console.WriteLine("|         `._____|_________|______/              |       |");
            Console.WriteLine("|         _________________________>----------- |        |      ");
            Console.WriteLine("|        /       |         |       `.    " + v[11] + "     /        |   ");
            Console.WriteLine("|       /    " + v[8] + "  |    " + v[9] + "   |    " + v[10] + "");
            Console.WriteLine("|      |         |_________|___________`._____/          |");
            Console.WriteLine("|      |--------<____________________________            |");
            Console.WriteLine("|      |         |         |        /         `.         |");
            Console.WriteLine("|       `.   " + v[7] + "  |   " + v[6] + "    |   " + v[5] + "  /     " + v[4] + "     `.       |");
            Console.WriteLine("|         `._____|_________|______/              |       | ");
            Console.WriteLine("|        _________________________> -------------|       |");
            Console.WriteLine("|       |        |         |      `.             /       |");
            Console.WriteLine("|       |   "+v[0]+"   |   "+v[1]+"    |  "+v[2]+"    `.   "+v[3]+"     /        |");
            Console.WriteLine("|       |________|_________|__________`._______/         |");
            Console.WriteLine("|                                                        |");
            Console.WriteLine("|                                                        |");
            Console.WriteLine("|________________________________________________________|");
            Console.WriteLine();
            Console.WriteLine("  VUELvE A LANSAR EL DADO PRECIONANDO CUALQUIER TECLA");
            Console.WriteLine("");
        }
        public int lanzar()
        {

            Random random = new Random();
            return random.Next(1, 7);

        }

        public void preguntasFacil()
        {
            Random r = new Random();
            int opcion = r.Next(1, 20);

            switch (opcion)
            {
                case 1:
                    Console.WriteLine("¿ cuanto es ?= 2 + 4 - 4 * 4 / 4");
                    string resPreg = "2";
                    Console.WriteLine("");
                    string resp = Console.ReadLine();
                    if (resPreg.Equals(resp.Trim()))
                    {
                        Console.WriteLine("");
                        Console.WriteLine("");
                        Console.WriteLine("          ¡¡¡¡¡ CORRECTO !!!!!");
                    }
                    else
                    {
                        Console.WriteLine("");
                        Console.WriteLine("");
                        Console.WriteLine("          ¡¡¡¡¡ INCORRECTO !!!!!");
                    }
                    break;

                case 2:
                    Console.WriteLine(" ¿CUANTO ES EL FACTORIAL DE 5 ? = 5!");
                    string resPreg1 = "120";

                    string resp1 = Console.ReadLine();

                    if (resPreg1.Equals(resp1.Trim()))
                    {
                        Console.WriteLine("");
                        Console.WriteLine("");
                        Console.WriteLine("          ¡¡¡¡¡ CORRECTO !!!!!");
                    }
                    else
                    {
                        Console.WriteLine("");
                        Console.WriteLine("");
                        Console.WriteLine("          ¡¡¡¡¡ INCORRECTO !!!!!");
                    }
                    break;

                case 3:
                    Console.WriteLine(" ¿CUAL ES LA RED SOCIAL MAS CONOCIDAD ENTRE ESTAS 3 OPCIONES?");
                    Console.WriteLine(" A) TWITTER         B)FACEBOOK            C)SONICO");
                    string resPreg3 = "b";

                    string resp3 = Console.ReadLine();
                    if (resPreg3.Equals(resp3.Trim()))
                    {
                        Console.WriteLine("");
                        Console.WriteLine("");
                        Console.WriteLine("          ¡¡¡¡¡ CORRECTO !!!!!");
                    }
                    else
                    {
                        Console.WriteLine("");
                        Console.WriteLine("");
                        Console.WriteLine("          ¡¡¡¡¡ INCORRECTO !!!!!");
                    }
                    break;
                case 4:
                    Console.WriteLine(" CUAL DE ESTAS OPCIONES NO ES UN MOTOR DE BASE DE DATOS");
                    Console.WriteLine(" A) SQL SERVER    B) MONGO DB     C)MYSQL     D)CYBERLIGTH");

                    string resPreg4 = "d";

                    string resp4 = Console.ReadLine();

                    if (resPreg4.Equals(resp4.Trim()))
                    {
                        Console.WriteLine("");
                        Console.WriteLine("");
                        Console.WriteLine("          ¡¡¡¡¡ CORRECTO !!!!!");
                    }
                    else
                    {
                        Console.WriteLine("");
                        Console.WriteLine("");
                        Console.WriteLine("          ¡¡¡¡¡ INCORRECTO !!!!!");
                    }
                    break;
                case 5:
                    Console.WriteLine(" ¿EL CREADOR DE FACEBOOK SE LLAMA STEVE HOUKEN?");
                    Console.WriteLine("             SI                  NO");
                    string resPreg5 = "no";

                    string resp5 = Console.ReadLine();
                    if (resPreg5.Equals(resp5.Trim()))
                    {
                        Console.WriteLine("");
                        Console.WriteLine("");
                        Console.WriteLine("          ¡¡¡¡¡ CORRECTO !!!!!");
                    }
                    else
                    {
                        Console.WriteLine("");
                        Console.WriteLine("");
                        Console.WriteLine("          ¡¡¡¡¡ INCORRECTO !!!!!");
                    }
                    break;
                case 6:
                    Console.WriteLine("  ¿CUAL DE ESTOS NUMERO NO ES NUMERO PRIMO?");
                    Console.WriteLine("   2 3 3 5 7 11 13 14 17 19 23 29 31 37");
                    string resPreg6 = "14";
                    string resp6 = Console.ReadLine();
                    if (resPreg6.Equals(resp6.Trim()))
                    {
                        Console.WriteLine("");
                        Console.WriteLine("");
                        Console.WriteLine("          ¡¡¡¡¡ CORRECTO !!!!!");
                    }
                    else
                    {
                        Console.WriteLine("");
                        Console.WriteLine("");
                        Console.WriteLine("          ¡¡¡¡¡ INCORRECTO !!!!!");
                    }
                    break;
                case 7:
                    Console.WriteLine("  ¿EN QUE AÑO FALLECIO ROBERTO GPMEZ BOLAÑOS?");
                    Console.WriteLine("      2014          1995            2015");
                    string resPreg7 = "2014";
                    string resp7 = Console.ReadLine();
                    if (resPreg7.Equals(resp7.Trim()))
                    {
                        Console.WriteLine("");
                        Console.WriteLine("");
                        Console.WriteLine("          ¡¡¡¡¡ CORRECTO !!!!!");
                    }
                    else
                    {
                        Console.WriteLine("");
                        Console.WriteLine("");
                        Console.WriteLine("          ¡¡¡¡¡ INCORRECTO !!!!!");
                    }
                    break;
                case 8:
                    Console.WriteLine("  ¿CUANTOS FUERON LOS QUE INICIARON CON LA CREACION DE FACEBOOK?");
                    Console.WriteLine("         2           4           6           8       10");
                    string resPreg8 = "4";
                    string resp8 = Console.ReadLine();
                    if (resPreg8.Equals(resp8.Trim()))
                    {
                        Console.WriteLine("");
                        Console.WriteLine("");
                        Console.WriteLine("          ¡¡¡¡¡ CORRECTO !!!!!");
                    }
                    else
                    {
                        Console.WriteLine("");
                        Console.WriteLine("");
                        Console.WriteLine("          ¡¡¡¡¡ INCORRECTO !!!!!");
                    }
                    break;
                case 9:
                    Console.WriteLine("  ¿CUAL ES EL VIDEOBLOGERS ES MAS VISTO EN YOUTUBE DE COMEDIA?");
                    Console.WriteLine("   A) ENCHUFE TV        B) HOLA SOY GERMAN          C) WEREBER TOMORROW");
                    string resPreg9 = "a";
                    string resp9 = Console.ReadLine();
                    if (resPreg9.Equals(resp9.Trim()))
                    {
                        Console.WriteLine("");
                        Console.WriteLine("");
                        Console.WriteLine("          ¡¡¡¡¡ CORRECTO !!!!!");
                    }
                    else
                    {
                        Console.WriteLine("");
                        Console.WriteLine("");
                        Console.WriteLine("          ¡¡¡¡¡ INCORRECTO !!!!!");
                    }
                    break;
                case 10:
                    Console.WriteLine("  ¿CUALES SON LAS REGLAS PRINCIÀLES DE LOS INCAS?");
                    Console.WriteLine("   A) AMASUHA     B) AMALLULLA     C) AMAQKELLA    D) TODAS LAS ANTERIORES");
                    string resPreg10 = "d";
                    string resp10 = Console.ReadLine();
                    if (resPreg10.Equals(resp10.Trim()))
                    {
                        Console.WriteLine("");
                        Console.WriteLine("");
                        Console.WriteLine("          ¡¡¡¡¡ CORRECTO !!!!!");
                    }
                    else
                    {
                        Console.WriteLine("");
                        Console.WriteLine("");
                        Console.WriteLine("          ¡¡¡¡¡ INCORRECTO !!!!!");
                    }
                    break;
                case 11:
                    Console.WriteLine("  ¿QUIEN COMPUSO LA UNA SIMFONIA CON 4 MODIA ?");
                    Console.WriteLine("   A) BEETHOVEN      B) MMOTZHAT     C) SCHOPAN");
                    string resPreg11 = "a";
                    string resp11 = Console.ReadLine();
                    if (resPreg11.Equals(resp11.Trim()))
                    {
                        Console.WriteLine("");
                        Console.WriteLine("");
                        Console.WriteLine("          ¡¡¡¡¡ CORRECTO !!!!!");
                    }
                    else
                    {
                        Console.WriteLine("");
                        Console.WriteLine("");
                        Console.WriteLine("          ¡¡¡¡¡ INCORRECTO !!!!!");
                    }
                    break;
                case 12:
                    Console.WriteLine("  ¿EL NOMBRE COMPLETO DE APU ES APUNAJASAPENAPETILONE?");
                    Console.WriteLine("                 SI                  NO");
                    string resPreg12 = "si";
                    string resp12 = Console.ReadLine();
                    if (resPreg12.Equals(resp12.Trim()))
                    {
                        Console.WriteLine("");
                        Console.WriteLine("");
                        Console.WriteLine("          ¡¡¡¡¡ CORRECTO !!!!!");
                    }
                    else
                    {
                        Console.WriteLine("");
                        Console.WriteLine("");
                        Console.WriteLine("          ¡¡¡¡¡ INCORRECTO !!!!!");
                    }
                    break;
                case 13:
                    Console.WriteLine("  ¿UN HOMBRE VENDE QUESO, SU CASA QUESERIA?");
                    Console.WriteLine("   ");
                    string resPreg13 = "queseria";
                    string resp13 = Console.ReadLine();
                    if (resPreg13.Equals(resp13.Trim()))
                    {
                        Console.WriteLine("");
                        Console.WriteLine("");
                        Console.WriteLine("          ¡¡¡¡¡ CORRECTO !!!!!");
                    }
                    else
                    {
                        Console.WriteLine("");
                        Console.WriteLine("");
                        Console.WriteLine("          ¡¡¡¡¡ INCORRECTO !!!!!");
                    }
                    break;
                case 14:
                    Console.WriteLine("  ¿UN HOMBRE VENDE LECHE, SU CASA QUESERIA?");
                    Console.WriteLine("   A) QUESERIA       B) LECHERIA     C) LA SUPERIA");
                    string resPreg14 = "b";
                    string resp14 = Console.ReadLine();
                    if (resPreg14.Equals(resp14.Trim()))
                    {
                        Console.WriteLine("");
                        Console.WriteLine("");
                        Console.WriteLine("          ¡¡¡¡¡ CORRECTO !!!!!");
                    }
                    else
                    {
                        Console.WriteLine("");
                        Console.WriteLine("");
                        Console.WriteLine("          ¡¡¡¡¡ INCORRECTO !!!!!");
                    }
                    break;
                case 15:
                    Console.WriteLine("  ¿CUANTAS VECES FUE INTENTADA LA CREACION DE LA BOMBILLA?");
                    Console.WriteLine("   ");
                    string resPreg15 = "1000";
                    string resp15 = Console.ReadLine();
                    if (resPreg15.Equals(resp15.Trim()))
                    {
                        Console.WriteLine("");
                        Console.WriteLine("");
                        Console.WriteLine("          ¡¡¡¡¡ CORRECTO !!!!!");
                    }
                    else
                    {
                        Console.WriteLine("");
                        Console.WriteLine("");
                        Console.WriteLine("          ¡¡¡¡¡ INCORRECTO !!!!!");
                    }
                    break;
                case 16:
                    Console.WriteLine("  ¿COMO MURIO LUDVEN BAN BEETHOVEN?");
                    Console.WriteLine("   A) ALCOHOLISADO   B) PROBLEMAS DEL ESTOMAGO   C) EN UNA PECENTACION");
                    string resPreg16 = "b";
                    string resp16 = Console.ReadLine();
                    if (resPreg16.Equals(resp16.Trim()))
                    {
                        Console.WriteLine("");
                        Console.WriteLine("");
                        Console.WriteLine("          ¡¡¡¡¡ CORRECTO !!!!!");
                    }
                    else
                    {
                        Console.WriteLine("");
                        Console.WriteLine("");
                        Console.WriteLine("          ¡¡¡¡¡ INCORRECTO !!!!!");
                    }
                    break;
                case 17:
                    Console.WriteLine("  ¿EL GRAN COMPOCITOR MOTZART FUE UN NIÑO PRODIGIO?");
                    Console.WriteLine("             SI                   NO  ");
                    string resPreg17 = "si";
                    string resp17 = Console.ReadLine();
                    if (resPreg17.Equals(resp17.Trim()))
                    {
                        Console.WriteLine("");
                        Console.WriteLine("");
                        Console.WriteLine("          ¡¡¡¡¡ CORRECTO !!!!!");
                    }
                    else
                    {
                        Console.WriteLine("");
                        Console.WriteLine("");
                        Console.WriteLine("          ¡¡¡¡¡ INCORRECTO !!!!!");
                    }
                    break;
                case 18:
                    Console.WriteLine("  ¿A QUE REINO ALIMENTICIO PERTENECE LA PAPA?");
                    Console.WriteLine("   A) ALMIDON        B) TUBERCULO        C) VEGETAL");
                    string resPreg18 = "b";
                    string resp18 = Console.ReadLine();
                    if (resPreg18.Equals(resp18.Trim()))
                    {
                        Console.WriteLine("");
                        Console.WriteLine("");
                        Console.WriteLine("          ¡¡¡¡¡ CORRECTO !!!!!");
                    }
                    else
                    {
                        Console.WriteLine("");
                        Console.WriteLine("");
                        Console.WriteLine("          ¡¡¡¡¡ INCORRECTO !!!!!");
                    }
                    break;
                case 19:
                    Console.WriteLine("  ¿EL LIMON ES UN NUTRIENTE PARA LA PIEL?");
                    Console.WriteLine("             SI              NO");
                    string resPreg19 = "si";
                    string resp19 = Console.ReadLine();
                    if (resPreg19.Equals(resp19.Trim()))
                    {
                        Console.WriteLine("");
                        Console.WriteLine("");
                        Console.WriteLine("          ¡¡¡¡¡ CORRECTO !!!!!");
                    }
                    else
                    {
                        Console.WriteLine("");
                        Console.WriteLine("");
                        Console.WriteLine("          ¡¡¡¡¡ INCORRECTO !!!!!");
                    }
                    break;
                case 20:
                    Console.WriteLine("  ¿EL PIANO ES UN INSTRUMENTO DE?");
                    Console.WriteLine("   A) VIENTO     B) PERCUCION     C) CUERDA      D)DIGITAL");
                    string resPreg20 = "c";
                    string resp20 = Console.ReadLine();
                    if (resPreg20.Equals(resp20.Trim()))
                    {
                        Console.WriteLine("");
                        Console.WriteLine("");
                        Console.WriteLine("          ¡¡¡¡¡ CORRECTO !!!!!");
                    }
                    else
                    {
                        Console.WriteLine("");
                        Console.WriteLine("");
                        Console.WriteLine("          ¡¡¡¡¡ INCORRECTO !!!!!");
                    }
                    break;
                default:
                    Console.WriteLine("opcion no valida");
                    break;
            }
        }
        public void menuInicio()
        {
            Console.WriteLine("                __________________________________________________");
            Console.WriteLine("               |           ....*                                   |");
            Console.WriteLine("               |           .          VIBORITA                     |");
            Console.WriteLine("               |       .....                               *...... |");
            Console.WriteLine("               |       .                                        .  |");
            Console.WriteLine("               |       .       1. INICIO DEL JUEGO              .  |");
            Console.WriteLine("               |       .                                  .......  |");
            Console.WriteLine("               |     ...            2. SALIR              .        |");
            Console.WriteLine("               |     .                              ..... .        |");
            Console.WriteLine("               |     .                              .              |");
            Console.WriteLine("               |     .....                          .              |");
            Console.WriteLine("               |         .                          .              |");
            Console.WriteLine("               |         .             ..............              |");
            Console.WriteLine("               |         .                                         |");
            Console.WriteLine("               |         ...................                       |");
            Console.WriteLine("               |___________________________________________________|");

        }
        public void menuNivel()
        {
            Console.WriteLine("                __________________________________________________");
            Console.WriteLine("               |                                                  |");
            Console.WriteLine("               |                     VIBORITA                     |");
            Console.WriteLine("               |                                                  |");
            Console.WriteLine("               |                                                  |");
            Console.WriteLine("               |                    1. FACIL                      |");
            Console.WriteLine("               |                                                  |");
            Console.WriteLine("               |                    2. MEDIO                      |");
            Console.WriteLine("               |                                                  |");
            Console.WriteLine("               |                   3. DIFICIL                     |");
            Console.WriteLine("               |                                                  |");
            Console.WriteLine("               |                   4. VOLVER                      |");
            Console.WriteLine("               |                                                  |");
            Console.WriteLine("               |__________________________________________________|");

        }
    }   
}
