﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.Models;

namespace TrackerLibrary
{
	public static class TournamentLogic
	{
		// Order our list randomly of teams 
		// Check if it is big enough - if not, add in byes - 2*2*2*2 - 2^4
		// Create our first round of matchups
		// Create every round after that - 8 matchups - 4 matchups - 2 matchups - 1 matchup
		public static void CreateRounds(TournamentModel model)
		{
			List<TeamModel> randomizeTeams = RandomizeTeamOrder(model.EnteredTeams);
			int rounds = FindNumberOfRounds(randomizeTeams.Count);
			int byes = NumberOfByes(rounds, randomizeTeams.Count);

			model.Rounds.Add(CreateFirstRound(byes, randomizeTeams));

			CreateOtherRounds(model, rounds);

		}
		private static void CreateOtherRounds(TournamentModel model, int rounds)
		{
			int round = 2;
			List<MatchupModel> previousRound = model.Rounds[0];
			List<MatchupModel> currentRound = new List<MatchupModel>();
			MatchupModel currentMatchup = new MatchupModel();
			while(round <= rounds)
			{
				foreach(MatchupModel match in previousRound)
				{
					currentMatchup.Entries.Add(new MatchupEntryModel { ParentMatchup = match });

					if(currentMatchup.Entries.Count > 1)
					{
						currentMatchup.MatchupRound = round;
						currentRound.Add(currentMatchup);
						currentMatchup = new MatchupModel();
					}	
				}

				model.Rounds.Add(currentRound);
				previousRound = currentRound;

				currentRound = new List<MatchupModel>();
				round += 1;
			}
		}
		private static List<MatchupModel> CreateFirstRound(int byes, List<TeamModel> teams)
		{
			List<MatchupModel> ouput = new List<MatchupModel>();
			MatchupModel currentMatchup = new MatchupModel();

			foreach(TeamModel team in teams)
			{
				MatchupEntryModel newEntry = new MatchupEntryModel { TeamCompeting = team };
				currentMatchup.Entries.Add(newEntry);

				if (byes > 0 || currentMatchup.Entries.Count > 1)
				{
					currentMatchup.MatchupRound = 1;
					ouput.Add(currentMatchup);
					currentMatchup = new MatchupModel();
					if (byes > 0)
					{
						byes -= 1;
					}
				}
			}
			return ouput;
		} 
		private static int FindNumberOfRounds(int teamCount)
		{
			int output = 1;
			int val = 2;
			while (val < teamCount)
			{
				output += 1;
				val *= 2;
			}
			return output;
		}
		private static int NumberOfByes(int rounds, int teamCount)
		{
			int output = 0;
			int totalTeams = 1;

			for(int i =1; i<=rounds; i++)
			{
				totalTeams*= 2;
			}

			output = totalTeams - teamCount;

			return output;
		}
		private static List<TeamModel> RandomizeTeamOrder(List<TeamModel> teams)
		{
			return teams.OrderBy(x => Guid.NewGuid()).ToList();
		}
	}
}
