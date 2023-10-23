int[,] coords = { { 0, 0, 0 }, { 0, 0, 0 } };
int n0 = 0;

String[] promptLetter = {"A", "B"};

String tmpStr = "";
const String errMessage = "You've entered not digital value";

for(int i=0; i < 2; i++) {

  for(int j=0; j<3; j++) {

    Console.WriteLine("Enter " + (j+1).ToString() + " coord of point " + promptLetter[i]);
    tmpStr = Console.ReadLine();
    try
    {
    n0 = Convert.ToInt32(tmpStr);
    }
    catch (System.Exception)
    {
        Console.WriteLine(errMessage);
        Environment.Exit(0);
    }
    coords[i,j] = n0;

  }

}


Console.WriteLine("We have :");

for(int i=0; i < 2; i++) {

  tmpStr = promptLetter[i] + "(";

  for(int j=0; j<3; j++) {
    tmpStr += coords[i,j] + ",";
  }

    tmpStr += ")";
    Console.WriteLine(tmpStr);

}

double tmp3 = 0;
tmp3 = Math.Pow (coords[1,0] - coords[0,0],2) + Math.Pow (coords[1,1] - coords[0,1],2) + Math.Pow (coords[1,2] - coords[0,2],2);
tmp3 = Math.Pow(tmp3, 0.5);

Console.WriteLine(tmp3.ToString() );

