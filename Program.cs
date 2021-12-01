using System;

namespace ejercicio_practico_3er_corte
{
    class Program
    {
        static void Main(string[] args)
        {
            string dato="";
            int tamaño =0;
            int edad=0;
            int edmeses=0;
            int actividad=0;
            int seleccion=0;
            double peso=0.0;

            Console.WriteLine("Bienvenido a el programa: ¿Cuanto debe comer tu perro?");
            Console.WriteLine("Para ello debes:");

            Console.WriteLine("Indicarnos su edad, si es un cachorro menor a 12 meses de edad marca 1, si es adulto marca 2");
            dato=Console.ReadLine();
            edad=Convert.ToInt32(dato);

            

            switch(edad){
                // cachorros
                case 1:
                Console.WriteLine("Para conocer mejor a tu cachorro, indicanos cuantos meses de edad tiene si es mayor a dos meses:");
                dato=Console.ReadLine();
                edmeses=Convert.ToInt32(dato);

                Console.WriteLine("De que tamaño es tu perro? 1: Miniatura, 2: Pequeño, 3: Mediano, 4:Grande");
                dato=Console.ReadLine();
                tamaño=Convert.ToInt32(dato);

                //clasificacion por edad de los cachorros
                switch(edmeses){

                    case 2:
                    // clasificacion del tamaño de los cachorros
                    switch (tamaño){
                        //tamaño miniatura
                        case 1:
                        Console.WriteLine("El peso que debe alcanzar tu perro de tamaño miniatura en la adultez es de 2kg, y debe comer 50 gramos de alimento seco hasta alcanzar los 3 meses de edad");
                        break;

                        //tamaño pequeño
                        case 2:
                        Console.WriteLine("Por favor indicanos que peso debe alcanzar tu cachorro de tamaño pequeño cuando sea adulto,  1: 5kg  o  2: 10kg");
                        dato=Console.ReadLine();
                        seleccion=Convert.ToInt32(dato);

                        if (seleccion==1){
                            Console.WriteLine("Tu perro de tamaño pequeño debe comer 95 gramos de alimento seco hasta alcanzar los 3 meses de edad");
                        }
                        if (seleccion==2){
                        Console.WriteLine("Tu perro de tamaño pequeño debe comer 155 gramos de alimento seco hasta alcanzar los 3 meses de edad");
                        }
                        break;

                        //tamaño mediano
                        case 3:
                        Console.WriteLine("El peso que debe alcanzar tu perro en la adultez es de 17kg, y debe comer 215 gramos de alimento seco hasta los 3 meses de edad");
                        break;

                        //tamaño grande
                        case 4:
                        Console.WriteLine("Por favor indicanos que peso debe alcanzar tu cachorro de tamaño grande cuando sea adulto");
                        Console.WriteLine("selecciona: 1:25kg, 2:32kg, 3:40kg, 4:50kg, 5:60kg, 6:70kg, 7:90kg");
                        dato=Console.ReadLine();
                        seleccion=Convert.ToInt32(dato);

                        if (seleccion==1){
                            Console.WriteLine("Tu perro de tamaño grande debe comer 270 gramos de alimento seco hasta alcanzar los 3 meses de edad");
                        }
                        if (seleccion==2){
                        Console.WriteLine("Tu perro de tamaño grande debe comer 300 gramos de alimento seco hasta alcanzar los 3 meses de edad");
                        }
                        if (seleccion==3){
                            Console.WriteLine("Tu perro de tamaño grande debe comer 355 gramos de alimento seco hasta alcanzar los 3 meses de edad");
                        }
                        if (seleccion==4){
                        Console.WriteLine("Tu perro de tamaño grande debe comer 405 gramos de alimento seco hasta alcanzar los 3 meses de edad");
                        }
                        if (seleccion==5){
                            Console.WriteLine("Tu perro de tamaño grande debe comer 450 gramos de alimento seco hasta alcanzar los 3 meses de edad");
                        }
                        if (seleccion==6){
                        Console.WriteLine("Tu perro de tamaño grande debe comer 485 gramos de alimento seco hasta alcanzar los 3 meses de edad");
                        }
                        if (seleccion==7){
                            Console.WriteLine("Tu perro de tamaño grande debe comer 580 gramos de alimento seco hasta alcanzar los 3 meses de edad");
                        }
                        break;
                    }
                    //termina edad 2 meses
                    break;

                    case 3:
                    // clasificacion del tamaño de los cachorros
                    switch (tamaño){
                        //tamaño miniatura
                        case 1:
                        Console.WriteLine("El peso que debe alcanzar tu perro de tamaño miniatura en la adultez es de 2kg, y debe comer  60 gramos de alimento seco hasta alcanzar los  meses 6 de edad");
                        break;

                        //tamaño pequeño
                        case 2:
                        Console.WriteLine("Por favor indicanos que peso debe alcanzar tu cachorro de tamaño pequeño cuando sea adulto,  1: 5kg  o  2: 10kg");
                        dato=Console.ReadLine();
                        seleccion=Convert.ToInt32(dato);

                        if (seleccion==1){
                            Console.WriteLine("Tu perro de tamaño pequeño debe comer 110 gramos de alimento seco hasta alcanzar los 4 meses de edad");
                        }
                        if (seleccion==2){
                        Console.WriteLine("Tu perro de tamaño pequeño debe comer 185 gramos de alimento seco hasta alcanzar los 4 meses de edad");
                        }
                        break;

                        //tamaño mediano
                        case 3:
                        Console.WriteLine("El peso que debe alcanzar tu perro en la adultez es de 17kg, y debe comer 265 gramos de alimento seco hasta los 4 meses de edad");
                        break;

                        //tamaño grande
                        case 4:
                        Console.WriteLine("Por favor indicanos que peso debe alcanzar tu cachorro de tamaño grande cuando sea adulto");
                        Console.WriteLine("selecciona: 1:25kg, 2:32kg, 3:40kg, 4:50kg, 5:60kg, 6:70kg, 7:90kg");
                        dato=Console.ReadLine();
                        seleccion=Convert.ToInt32(dato);

                        if (seleccion==1){
                            Console.WriteLine("Tu perro de tamaño grande debe comer 350 gramos de alimento seco hasta alcanzar los 4 meses de edad");
                        }
                        if (seleccion==2){
                        Console.WriteLine("Tu perro de tamaño grande debe comer 400 gramos de alimento seco hasta alcanzar los 4 meses de edad");
                        }
                        if (seleccion==3){
                            Console.WriteLine("Tu perro de tamaño grande debe comer 475 gramos de alimento seco hasta alcanzar los 4 meses de edad");
                        }
                        if (seleccion==4){
                        Console.WriteLine("Tu perro de tamaño grande debe comer 545 gramos de alimento seco hasta alcanzar los 4 meses de edad");
                        }
                        if (seleccion==5){
                            Console.WriteLine("Tu perro de tamaño grande debe comer 605 gramos de alimento seco hasta alcanzar los 4 meses de edad");
                        }
                        if (seleccion==6){
                        Console.WriteLine("Tu perro de tamaño grande debe comer 670 gramos de alimento seco hasta alcanzar los 4 meses de edad");
                        }
                        if (seleccion==7){
                            Console.WriteLine("Tu perro de tamaño grande debe comer 670 gramos de alimento seco hasta alcanzar los 4 meses de edad");
                        }
                        break;
                    }
                    //termina edad 3 meses
                    break;

                    case 4:
                    // clasificacion del tamaño de los cachorros
                    switch (tamaño){
                        //tamaño miniatura
                        case 1:
                        Console.WriteLine("El peso que debe alcanzar tu perro de tamaño miniatura en la adultez es de 2kg, y debe comer  60 gramos de alimento seco hasta alcanzar los 6 meses de edad");
                        break;

                        //tamaño pequeño
                        case 2:
                        Console.WriteLine("Por favor indicanos que peso debe alcanzar tu cachorro de tamaño pequeño cuando sea adulto,  1: 5kg  o  2: 10kg");
                        dato=Console.ReadLine();
                        seleccion=Convert.ToInt32(dato);

                        if (seleccion==1){
                            Console.WriteLine("Tu perro de tamaño pequeño debe comer 115 gramos de alimento seco hasta alcanzar los 6 meses de edad");
                        }
                        if (seleccion==2){
                        Console.WriteLine("Tu perro de tamaño pequeño debe comer 195 gramos de alimento seco hasta alcanzar los 5 meses de edad");
                        }
                        break;

                        //tamaño mediano
                        case 3:
                        Console.WriteLine("El peso que debe alcanzar tu perro en la adultez es de 17kg, y debe comer 285 gramos de alimento seco hasta los 6 meses de edad");
                        break;

                        //tamaño grande
                        case 4:
                        Console.WriteLine("Por favor indicanos que peso debe alcanzar tu cachorro de tamaño grande cuando sea adulto");
                        Console.WriteLine("selecciona: 1:25kg, 2:32kg, 3:40kg, 4:50kg, 5:60kg, 6:70kg, 7:90kg");
                        dato=Console.ReadLine();
                        seleccion=Convert.ToInt32(dato);

                        if (seleccion==1){
                            Console.WriteLine("Tu perro de tamaño grande debe comer 375 gramos de alimento seco hasta alcanzar los 6 meses de edad");
                        }
                        if (seleccion==2){
                        Console.WriteLine("Tu perro de tamaño grande debe comer 445 gramos de alimento seco hasta alcanzar los 5 meses de edad");
                        }
                        if (seleccion==3){
                            Console.WriteLine("Tu perro de tamaño grande debe comer 525 gramos de alimento seco hasta alcanzar los 5 meses de edad");
                        }
                        if (seleccion==4){
                        Console.WriteLine("Tu perro de tamaño grande debe comer 610 gramos de alimento seco hasta alcanzar los 5 meses de edad");
                        }
                        if (seleccion==5){
                            Console.WriteLine("Tu perro de tamaño grande debe comer 685 gramos de alimento seco hasta alcanzar los 5 meses de edad");
                        }
                        if (seleccion==6){
                        Console.WriteLine("Tu perro de tamaño grande debe comer 685 gramos de alimento seco hasta alcanzar los 5 meses de edad");
                        }
                        if (seleccion==7){
                            Console.WriteLine("Tu perro de tamaño grande debe comer 685 gramos de alimento seco hasta alcanzar los 5 meses de edad");
                        }
                        break;
                    }
                    //termina edad 4 meses
                    break;

                    case 5:
                    // clasificacion del tamaño de los cachorros
                    switch (tamaño){
                        //tamaño miniatura
                        case 1:
                        Console.WriteLine("El peso que debe alcanzar tu perro de tamaño miniatura en la adultez es de 2kg, y debe comer  60 gramos de alimento seco hasta alcanzar los  meses 6 de edad");
                        break;

                        //tamaño pequeño
                        case 2:
                        Console.WriteLine("Por favor indicanos que peso debe alcanzar tu cachorro de tamaño pequeño cuando sea adulto,  1: 5kg  o  2: 10kg");
                        dato=Console.ReadLine();
                        seleccion=Convert.ToInt32(dato);

                        if (seleccion==1){
                            Console.WriteLine("Tu perro de tamaño pequeño debe comer 115 gramos de alimento seco hasta alcanzar los 6 meses de edad");
                        }
                        if (seleccion==2){
                        Console.WriteLine("Tu perro de tamaño pequeño debe comer 190 gramos de alimento seco hasta alcanzar los 6 meses de edad");
                        }
                        break;

                        //tamaño mediano
                        case 3:
                        Console.WriteLine("El peso que debe alcanzar tu perro en la adultez es de 17kg, y debe comer 285 gramos de alimento seco hasta los 6 meses de edad");
                        break;

                        //tamaño grande
                        case 4:
                        Console.WriteLine("Por favor indicanos que peso debe alcanzar tu cachorro de tamaño grande cuando sea adulto");
                        Console.WriteLine("selecciona: 1:25kg, 2:32kg, 3:40kg, 4:50kg, 5:60kg, 6:70kg, 7:90kg");
                        dato=Console.ReadLine();
                        seleccion=Convert.ToInt32(dato);

                        if (seleccion==1){
                            Console.WriteLine("Tu perro de tamaño grande debe comer 375 gramos de alimento seco hasta alcanzar los 6 meses de edad");
                        }
                        if (seleccion==2){
                        Console.WriteLine("Tu perro de tamaño grande debe comer 450 gramos de alimento seco hasta alcanzar los 6 meses de edad");
                        }
                        if (seleccion==3){
                            Console.WriteLine("Tu perro de tamaño grande debe comer 530 gramos de alimento seco hasta alcanzar los 6 meses de edad");
                        }
                        if (seleccion==4){
                        Console.WriteLine("Tu perro de tamaño grande debe comer 625 gramos de alimento seco hasta alcanzar los 6 meses de edad");
                        }
                        if (seleccion==5){
                            Console.WriteLine("Tu perro de tamaño grande debe comer 685 gramos de alimento seco hasta alcanzar los 12 meses de edad");
                        }
                        if (seleccion==6){
                        Console.WriteLine("Tu perro de tamaño grande debe comer 685 gramos de alimento seco hasta alcanzar los 12 meses de edad");
                        }
                        if (seleccion==7){
                            Console.WriteLine("Tu perro de tamaño grande debe comer 685 gramos de alimento seco hasta alcanzar los 12 meses de edad");
                        }
                        break;
                    }
                    //termina edad 5 meses
                    break;

                    case 6:
                    case 7:
                    case 8:
                    case 9:
                    case 10:
                    case 11:
                    case 12:
                    // clasificacion del tamaño de los cachorros
                    switch (tamaño){
                        //tamaño miniatura
                        case 1:
                        Console.WriteLine("El peso que debe alcanzar tu perro de tamaño miniatura en la adultez es de 2kg, y debe comer  55 gramos de alimento seco hasta alcanzar los  meses 12 de edad cuando debe iniciar la dieta de adultos");
                        break;

                        //tamaño pequeño
                        case 2:
                        Console.WriteLine("Por favor indicanos que peso debe alcanzar tu cachorro de tamaño pequeño cuando sea adulto,  1: 5kg  o  2: 10kg");
                        dato=Console.ReadLine();
                        seleccion=Convert.ToInt32(dato);

                        if (seleccion==1){
                            Console.WriteLine("Tu perro de tamaño pequeño debe comer 110 gramos de alimento seco hasta alcanzar los 12 meses de edad cuando debe iniciar la dieta de adultos");
                        }
                        if (seleccion==2){
                        Console.WriteLine("Tu perro de tamaño pequeño debe comer 185 gramos de alimento seco hasta alcanzar los 12 meses de edad cuando debe iniciar la dieta de adutos");
                        }
                        break;

                        //tamaño mediano
                        case 3:
                        Console.WriteLine("El peso que debe alcanzar tu perro en la adultez es de 17kg, y debe comer 280 gramos de alimento seco hasta los 12 meses de edad cuando debe iniciar la dieta de adultos");
                        break;

                        //tamaño grande
                        case 4:
                        Console.WriteLine("Por favor indicanos que peso debe alcanzar tu cachorro de tamaño grande cuando sea adulto");
                        Console.WriteLine("selecciona: 1:25kg, 2:32kg, 3:40kg, 4:50kg, 5:60kg, 6:70kg, 7:90kg");
                        dato=Console.ReadLine();
                        seleccion=Convert.ToInt32(dato);

                        if (seleccion==1){
                            Console.WriteLine("Tu perro de tamaño grande debe comer 370 gramos de alimento seco hasta alcanzar los 12 meses de edad cuando debe iniciar la dieta de adultos");
                        }
                        if (seleccion==2){
                        Console.WriteLine("Tu perro de tamaño grande debe comer 450 gramos de alimento seco hasta alcanzar los 12 meses de edad cuando debe iniciar la dieta de adultos");
                        }
                        if (seleccion==3){
                            Console.WriteLine("Tu perro de tamaño grande debe comer 530 gramos de alimento seco hasta alcanzar los 12 meses de edad cuando debe iniciar la dieta de adultos");
                        }
                        if (seleccion==4){
                        Console.WriteLine("Tu perro de tamaño grande debe comer 625 gramos de alimento seco hasta alcanzar los 12 meses de edad cuando debe iniciar la dieta de adultos");
                        }
                        if (seleccion==5){
                            Console.WriteLine("Tu perro de tamaño grande debe comer 685 gramos de alimento seco hasta alcanzar los 12 meses de edad cuando debe iniciar la dieta de adultos");
                        }
                        if (seleccion==6){
                        Console.WriteLine("Tu perro de tamaño grande debe comer 685 gramos de alimento seco hasta alcanzar los 12 meses de edad cuando debe iniciar la dieta de adultos");
                        }
                        if (seleccion==7){
                            Console.WriteLine("Tu perro de tamaño grande debe comer 685 gramos de alimento seco hasta alcanzar los 12 meses de edad cuando debe iniciar la dieta de adultos");
                        }
                        break;
                    }
                    //termina edad 6-12 meses
                    break;
                    //error al seleccionar la edad del cachorro
                    default:
                    Console.WriteLine("Error, el valor indicado no es correcto...");
                    break;
                }
                break;

                //adultos
                case 2:
                Console.WriteLine("Indicanos su peso en kilogramos");
                dato=Console.ReadLine();
                peso=Convert.ToDouble(dato);

                Console.WriteLine("¿Como consideras su actividad? 1: alta, 2:normal, 3:baja");
                dato=Console.ReadLine();
                actividad=Convert.ToInt32(dato);

                //tamaño miniatura
                if (peso<=5.0 && peso>=2.0){
                    switch (actividad){
                    
                    //actividad alta
                    case 1:
                    Console.WriteLine("Tu perro debe comer diariamente entre 60 y 115 gramos de alimento seco");
                    break;
                    
                    //actividad normal
                    case 2:
                    Console.WriteLine("Tu perro debe comer diariamente entre 55 y 100 gramos de alimento seco");
                    break;
                    
                    //actividad baja
                    case 3:
                    Console.WriteLine("Tu perro debe comer diariamente entre 45 y 85 gramos de alimento seco");
                    break;
                    
                    //error al seleccionar actividad
                    default:
                    Console.WriteLine("Error, el valor indicado no es correcto...");
                    break;
                    }
                }

                //tamaño pequeño
                if (peso<=10.0 && peso>=6.0){
                    switch (actividad){
                    
                    //actividad alta
                    case 1:
                    Console.WriteLine("Tu perro debe comer diariamente entre 115 y 190 gramos de alimento seco");
                    break;
                    
                    //actividad normal
                    case 2:
                    Console.WriteLine("Tu perro debe comer diariamente entre 100 y 170 gramos de alimento seco");
                    break;
                    
                    //actividad baja
                    case 3:
                    Console.WriteLine("Tu perro debe comer diariamente entre 85 y 145 gramos de alimento seco");
                    break;
                    
                    //error al seleccionar actividad
                    default:
                    Console.WriteLine("Error, el valor indicado no es correcto...");
                    break;
                    }
                }

                //tamaño mediano
                if (peso<=15.0 && peso>=11.0){
                    switch (actividad){
                    
                    //actividad alta
                    case 1:
                    Console.WriteLine("Tu perro debe comer diariamente entre 190 y 255 gramos de alimento seco");
                    break;
                    
                    //actividad normal
                    case 2:
                    Console.WriteLine("Tu perro debe comer diariamente entre 170 y 225 gramos de alimento seco");
                    break;
                    
                    //actividad baja
                    case 3:
                    Console.WriteLine("Tu perro debe comer diariamente entre 145 y 195 gramos de alimento seco");
                    break;
                    
                    //error al seleccionar actividad
                    default:
                    Console.WriteLine("Error, el valor indicado no es correcto...");
                    break;
                    }
                }

                //tamaño grande 1
                if (peso<=25.0 && peso>=16.0){
                    switch (actividad){
                    
                    //actividad alta
                    case 1:
                    Console.WriteLine("Tu perro debe comer diariamente entre 255 y 380 gramos de alimento seco");
                    break;
                    
                    //actividad normal
                    case 2:
                    Console.WriteLine("Tu perro debe comer diariamente entre 225 y 330 gramos de alimento seco");
                    break;
                    
                    //actividad baja
                    case 3:
                    Console.WriteLine("Tu perro debe comer diariamente entre 195 y 285 gramos de alimento seco");
                    break;
                    
                    //error al seleccionar actividad
                    default:
                    Console.WriteLine("Error, el valor indicado no es correcto...");
                    break;
                    }
                }

                //tamaño grande 2
                if (peso<=40.0 && peso>=26.0){
                    switch (actividad){
                    
                    //actividad alta
                    case 1:
                    Console.WriteLine("Tu perro debe comer diariamente entre 380 y 535 gramos de alimento seco");
                    break;
                    
                    //actividad normal
                    case 2:
                    Console.WriteLine("Tu perro debe comer diariamente entre 330 y 475 gramos de alimento seco");
                    break;
                    
                    //actividad baja
                    case 3:
                    Console.WriteLine("Tu perro debe comer diariamente entre 285 y 410 gramos de alimento seco");
                    break;
                    
                    //error al seleccionar actividad
                    default:
                    Console.WriteLine("Error, el valor indicado no es correcto...");
                    break;
                    }
                }

                //tamaño grande 3
                if (peso<=55.0 && peso>=41.0){
                    switch (actividad){
                    
                    //actividad alta
                    case 1:
                    Console.WriteLine("Tu perro debe comer diariamente entre 535 y 680 gramos de alimento seco");
                    break;
                    
                    //actividad normal
                    case 2:
                    Console.WriteLine("Tu perro debe comer diariamente entre 475 y 600 gramos de alimento seco");
                    break;
                    
                    //actividad baja
                    case 3:
                    Console.WriteLine("Tu perro debe comer diariamente entre 410 y 520 gramos de alimento seco");
                    break;
                    
                    //error al seleccionar actividad
                    default:
                    Console.WriteLine("Error, el valor indicado no es correcto...");
                    break;
                    }
                }

                //tamaño grande 4
                if (peso<=70.0 && peso>=56.0){
                    switch (actividad){
                    
                    //actividad alta
                    case 1:
                    Console.WriteLine("Tu perro debe comer diariamente entre 680 y 820 gramos de alimento seco");
                    break;
                    
                    //actividad normal
                    case 2:
                    Console.WriteLine("Tu perro debe comer diariamente entre 600 y 720 gramos de alimento seco");
                    break;
                    
                    //actividad baja
                    case 3:
                    Console.WriteLine("Tu perro debe comer diariamente entre 520 y 620 gramos de alimento seco");
                    break;
                    
                    //error al seleccionar actividad
                    default:
                    Console.WriteLine("Error, el valor indicado no es correcto...");
                    break;
                    }
                }

                //tamaño grande 5
                if (peso<=90.0 && peso>=71.0){
                    switch (actividad){
                    
                    //actividad alta
                    case 1:
                    Console.WriteLine("Tu perro debe comer diariamente entre 820 y 985 gramos de alimento seco");
                    break;
                    
                    //actividad normal
                    case 2:
                    Console.WriteLine("Tu perro debe comer diariamente entre 720 y 870 gramos de alimento seco");
                    break;
                    
                    //actividad baja
                    case 3:
                    Console.WriteLine("Tu perro debe comer diariamente entre 620 y 750 gramos de alimento seco");
                    break;
                    
                    //error al seleccionar actividad
                    default:
                    Console.WriteLine("Error, el valor indicado no es correcto...");
                    break;
                    }
                }

                break;

                //error al indicar la edad
              default:
              Console.WriteLine("Error, el valor indicado no es correcto...");
              break;
            }
        }
    }
}
