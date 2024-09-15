//start main
DisplayEnjoymentLevels();
GetEnjoymentLevel();
string enjoymentLevel = GetEnjoymentLevel();
GetStadiumRecommendation(enjoymentLevel);
string stadium = GetStadiumRecommendation();
GetGameRecommendation(stadium);
string game = GetGameRecommendation
DisplayStadiumDetails(string stadium, string game);

//end main

static return DisplayEnjoymentLevels(){
	Console.Writeline("1. Attend boring game\n2. Attend average game\n3. Attend fun game\n4. Attend epic game");
}

static string GetEnjoymentLevel(){
	Console.Writeline("Enter your choice");
	return (Console.Readline());
}

static void GetStadiumRecommendation(string enjoymentLevel){
	switch(enjoymentLevel){
		case "1": 
			Console.WriteLine("Neyland Stadium");
			break;
		case "2":
			Console.WriteLine("Jordan-Hare Stadium");
			break;
		case "3":
			Console.WriteLine("Tiger Stadium");
			break;
		case "4":
			Console.WriteLine("Saban Field at Bryant-Denny Stadium");
			break;
		case 5:
			Console.Writeline("Invalid selection")
			break;
	}
}

static void GetGameRecommendation(string stadium){
	switch(stadium){
		case "Neyland Stadium": 
			Console.WriteLine("vs Kent State");
			break;
		case "Jordan-Hare Stadium":
			Console.WriteLine("vs Kentucky");
			break;
		case "Tiger Stadium":
			Console.WriteLine("vs Alabama");
			break;
		case "Saban Field at Bryant-Denny Stadium":
			Console.WriteLine("vs Auburn");
			break;
	}
}

DisplayStadiumDetails(string stadium, string game){
    Console.WriteLine("You should attend" + string stadium, string game)
}