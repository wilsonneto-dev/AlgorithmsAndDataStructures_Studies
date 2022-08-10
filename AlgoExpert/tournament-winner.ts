// https://www.algoexpert.io/questions/tournament-winner

// 22/08/10 -> 36 minutes -> t = O(n) / m = o(m) 

export function tournamentWinner(competitions: string[][], results: number[]) {
    let teamsTable: { [key: string]: number } = {};
    let betterTeam = '';
    for(let competitionIdx = 0; competitionIdx < competitions.length; competitionIdx++)
    {
        var winnerTeam = competitions[competitionIdx][results[competitionIdx] == 1 ? 0 : 1];
        if(!teamsTable[winnerTeam])
          teamsTable[winnerTeam] = 3;
        else {
          teamsTable[winnerTeam] = teamsTable[winnerTeam] + 3;
        }

        if(betterTeam == '') betterTeam = winnerTeam;
        else if(teamsTable[betterTeam] < teamsTable[winnerTeam])
          betterTeam = winnerTeam;        

    }

    return betterTeam;
}
