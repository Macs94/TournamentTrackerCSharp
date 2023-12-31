﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.WebSockets;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using TrackerLibrary.Models;

namespace TrackerLibrary.DataAccess
{
    public class SqlConnector : IDataConnection
    {
        private const string db = "Tournaments";
        public PersonModel CreatePerson(PersonModel model)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(db)))
            {
                var p = new DynamicParameters();
                p.Add("@FirstName", model.FirstName);
                p.Add("@LastName", model.LastName);
                p.Add("@EmailAddress", model.EmailAddress);
                p.Add("@CellphoneNumber", model.CellphoneNumber);
                p.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                connection.Execute("dbo.spPeople_Insert", p, commandType: CommandType.StoredProcedure);

                model.Id = p.Get<int>("@id");

                return model;
            }
        }

        //TODO - Make the create prize method actually save to the database
        /// <summary>
        /// Saves a new prize to the database
        /// </summary>
        /// <param name="model">The prize information</param>
        /// <returns>The prize information, including the unique identifier</returns>
        public PrizeModel CreatePrize(PrizeModel model)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(db)))
            {
                var p = new DynamicParameters();
                p.Add("@PlaceNumber", model.PlaceNumber);
                p.Add("@PlaceName", model.PlaceName);
                p.Add("@PrizeAmount", model.PrizeAmount);
                p.Add("@PrizePercentage", model.PrizePercentage);
                p.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                connection.Execute("dbo.spPrizes_Insert", p, commandType: CommandType.StoredProcedure);
                 
                model.Id = p.Get<int>("@id");

                return model;
            }

        }

		public TeamModel CreateTeam(TeamModel model)
		{
			using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(db)))
            {
				var p = new DynamicParameters();
				p.Add("@TeamName", model.TeamName);
				p.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

				connection.Execute("dbo.spTeams_Insert", p, commandType: CommandType.StoredProcedure);

				model.Id = p.Get<int>("@id");

				foreach (PersonModel tm in model.TeamMembers)
                {
					p = new DynamicParameters();
					p.Add("@TeamId", model.Id);
					p.Add("@PersonId", tm.Id);

					connection.Execute("dbo.spTeamMembers_Insert", p, commandType: CommandType.StoredProcedure);
				}

				return model;
			}   
		}

		public void CreateTournament(TournamentModel model)
		{
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(db)))
            {
                SaveTournament(model, connection);

				SaveTournamentPrizes(model, connection);

				SaveTournamentEntries(model, connection);

				SaveTournamentRounds(model, connection);
               
                
			}
		}

		private void SaveTournamentRounds(TournamentModel model, IDbConnection connection)
		{

			foreach(List<MatchupModel> round in model.Rounds)
			{
				foreach(MatchupModel matchup in round)
				{
					var p = new DynamicParameters();
					p.Add("@TournamentId", model.Id);
					p.Add("@MatchupRound", matchup.MatchupRound);
					p.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);
					connection.Execute("dbo.spMatchups_Insert", p, commandType: CommandType.StoredProcedure);

					matchup.Id = p.Get<int>("@id");

					foreach(MatchupEntryModel entry in matchup.Entries)
					{
						p = new DynamicParameters();
						p.Add("@MatchupId", matchup.Id);
						if(entry.ParentMatchup == null)
						{
							p.Add("@ParentMatchupId", null);
						}
						else
						{
							p.Add("@ParentMatchupId", entry.ParentMatchup.Id);
						}	
	

						if(entry.TeamCompeting == null)
						{
							p.Add("@TeamCompetingId", null);
						}
						else
						{
							p.Add("@TeamCompetingId", entry.TeamCompeting.Id);
						}
						
						p.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

						connection.Execute("dbo.spMatchupEntries_Insert", p, commandType: CommandType.StoredProcedure);
					}
				}
			}
		}

		private void SaveTournament(TournamentModel model, IDbConnection connection)
        {
			var p = new DynamicParameters();
			p.Add("@TournamentName", model.TournamentName);
			p.Add("@EntryFee", model.EntryFee);
			p.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

			connection.Execute("dbo.spTournament_Insert", p, commandType: CommandType.StoredProcedure);

			model.Id = p.Get<int>("@id");
		}
        private void SaveTournamentPrizes(TournamentModel model, IDbConnection connection)
        {
			foreach (PrizeModel pz in model.Prizes)
			{
				var p = new DynamicParameters();
				p.Add("@TournamentId", model.Id);
				p.Add("@PrizeId", pz.Id);

				connection.Execute("dbo.spTournamentPrizes_Insert", p, commandType: CommandType.StoredProcedure);
			}
		}
        private void SaveTournamentEntries(TournamentModel model, IDbConnection connection)
        {
			foreach (TeamModel tm in model.EnteredTeams)
			{
				var p = new DynamicParameters();
				p.Add("@TournamentId", model.Id);
				p.Add("@TeamId", tm.Id);

				connection.Execute("dbo.spTournamentEntries_Insert", p, commandType: CommandType.StoredProcedure);
			}
			
		}

		public List<PersonModel> GetPerson_All()
		{

			List<PersonModel> output;
			using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(db)))
            {
                output = connection.Query<PersonModel>("dbo.spPeople_GetAll").ToList();
            }
            return output;
		}

		public List<TeamModel> GetTeam_All()
		{
			List<TeamModel> output;
			using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(db)))
			{
				output = connection.Query<TeamModel>("dbo.spTeam_GetAll").ToList();
                foreach(TeamModel team in output)
                {
					var p = new DynamicParameters();
					p.Add("@TeamId", team.Id);

					team.TeamMembers = connection.Query<PersonModel>("dbo.spTeamMembers_GetByTeam",p
                        , commandType: CommandType.StoredProcedure).ToList();
                }
			}
			return output;
		}
	}
}
