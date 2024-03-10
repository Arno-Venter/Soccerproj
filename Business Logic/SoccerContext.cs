using System;
using System.Collections.Generic;
using Domain;
using Microsoft.EntityFrameworkCore;

namespace Business_Logic;

public partial class SoccerContext : DbContext
{
    public SoccerContext()
    {
    }

    public SoccerContext(DbContextOptions<SoccerContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Country> Countries { get; set; }

    public virtual DbSet<League> Leagues { get; set; }

    public virtual DbSet<Match> Matches { get; set; }

    public virtual DbSet<Player> Players { get; set; }

    public virtual DbSet<PlayerAttribute> PlayerAttributes { get; set; }

    public virtual DbSet<Team> Teams { get; set; }

    public virtual DbSet<TeamAttribute> TeamAttributes { get; set; }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Country>(entity =>
        {
            entity.ToTable("Country");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Name)
                .HasColumnType("ntext")
                .HasColumnName("name");
        });

        modelBuilder.Entity<League>(entity =>
        {
            entity.ToTable("League");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CountryId).HasColumnName("country_id");
            entity.Property(e => e.Name)
                .HasColumnType("ntext")
                .HasColumnName("name");

            entity.HasOne(d => d.Country).WithMany(p => p.Leagues)
                .HasForeignKey(d => d.CountryId)
                .HasConstraintName("FK_Country_League");
        });

        modelBuilder.Entity<Match>(entity =>
        {
            entity.ToTable("Match");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AwayPlayer1).HasColumnName("away_player_1");
            entity.Property(e => e.AwayPlayer10).HasColumnName("away_player_10");
            entity.Property(e => e.AwayPlayer11).HasColumnName("away_player_11");
            entity.Property(e => e.AwayPlayer2).HasColumnName("away_player_2");
            entity.Property(e => e.AwayPlayer3).HasColumnName("away_player_3");
            entity.Property(e => e.AwayPlayer4).HasColumnName("away_player_4");
            entity.Property(e => e.AwayPlayer5).HasColumnName("away_player_5");
            entity.Property(e => e.AwayPlayer6).HasColumnName("away_player_6");
            entity.Property(e => e.AwayPlayer7).HasColumnName("away_player_7");
            entity.Property(e => e.AwayPlayer8).HasColumnName("away_player_8");
            entity.Property(e => e.AwayPlayer9).HasColumnName("away_player_9");
            entity.Property(e => e.AwayPlayerX1).HasColumnName("away_player_X1");
            entity.Property(e => e.AwayPlayerX10).HasColumnName("away_player_X10");
            entity.Property(e => e.AwayPlayerX11).HasColumnName("away_player_X11");
            entity.Property(e => e.AwayPlayerX2).HasColumnName("away_player_X2");
            entity.Property(e => e.AwayPlayerX3).HasColumnName("away_player_X3");
            entity.Property(e => e.AwayPlayerX4).HasColumnName("away_player_X4");
            entity.Property(e => e.AwayPlayerX5).HasColumnName("away_player_X5");
            entity.Property(e => e.AwayPlayerX6).HasColumnName("away_player_X6");
            entity.Property(e => e.AwayPlayerX7).HasColumnName("away_player_X7");
            entity.Property(e => e.AwayPlayerX8).HasColumnName("away_player_X8");
            entity.Property(e => e.AwayPlayerX9).HasColumnName("away_player_X9");
            entity.Property(e => e.AwayPlayerY1).HasColumnName("away_player_Y1");
            entity.Property(e => e.AwayPlayerY10).HasColumnName("away_player_Y10");
            entity.Property(e => e.AwayPlayerY11).HasColumnName("away_player_Y11");
            entity.Property(e => e.AwayPlayerY2).HasColumnName("away_player_Y2");
            entity.Property(e => e.AwayPlayerY3).HasColumnName("away_player_Y3");
            entity.Property(e => e.AwayPlayerY4).HasColumnName("away_player_Y4");
            entity.Property(e => e.AwayPlayerY5).HasColumnName("away_player_Y5");
            entity.Property(e => e.AwayPlayerY6).HasColumnName("away_player_Y6");
            entity.Property(e => e.AwayPlayerY7).HasColumnName("away_player_Y7");
            entity.Property(e => e.AwayPlayerY8).HasColumnName("away_player_Y8");
            entity.Property(e => e.AwayPlayerY9).HasColumnName("away_player_Y9");
            entity.Property(e => e.AwayTeamApiId).HasColumnName("away_team_api_id");
            entity.Property(e => e.AwayTeamGoal).HasColumnName("away_team_goal");
            entity.Property(e => e.B365a).HasColumnName("B365A");
            entity.Property(e => e.B365d).HasColumnName("B365D");
            entity.Property(e => e.B365h).HasColumnName("B365H");
            entity.Property(e => e.Bsa).HasColumnName("BSA");
            entity.Property(e => e.Bsd).HasColumnName("BSD");
            entity.Property(e => e.Bsh).HasColumnName("BSH");
            entity.Property(e => e.Bwa).HasColumnName("BWA");
            entity.Property(e => e.Bwd).HasColumnName("BWD");
            entity.Property(e => e.Bwh).HasColumnName("BWH");
            entity.Property(e => e.Card)
                .HasColumnType("ntext")
                .HasColumnName("card");
            entity.Property(e => e.Corner)
                .HasColumnType("ntext")
                .HasColumnName("corner");
            entity.Property(e => e.CountryId).HasColumnName("country_id");
            entity.Property(e => e.Cross)
                .HasColumnType("ntext")
                .HasColumnName("cross");
            entity.Property(e => e.Date)
                .HasColumnType("ntext")
                .HasColumnName("date");
            entity.Property(e => e.Foulcommit)
                .HasColumnType("ntext")
                .HasColumnName("foulcommit");
            entity.Property(e => e.Gba).HasColumnName("GBA");
            entity.Property(e => e.Gbd).HasColumnName("GBD");
            entity.Property(e => e.Gbh).HasColumnName("GBH");
            entity.Property(e => e.Goal)
                .HasColumnType("ntext")
                .HasColumnName("goal");
            entity.Property(e => e.HomePlayer1).HasColumnName("home_player_1");
            entity.Property(e => e.HomePlayer10).HasColumnName("home_player_10");
            entity.Property(e => e.HomePlayer11).HasColumnName("home_player_11");
            entity.Property(e => e.HomePlayer2).HasColumnName("home_player_2");
            entity.Property(e => e.HomePlayer3).HasColumnName("home_player_3");
            entity.Property(e => e.HomePlayer4).HasColumnName("home_player_4");
            entity.Property(e => e.HomePlayer5).HasColumnName("home_player_5");
            entity.Property(e => e.HomePlayer6).HasColumnName("home_player_6");
            entity.Property(e => e.HomePlayer7).HasColumnName("home_player_7");
            entity.Property(e => e.HomePlayer8).HasColumnName("home_player_8");
            entity.Property(e => e.HomePlayer9).HasColumnName("home_player_9");
            entity.Property(e => e.HomePlayerX1).HasColumnName("home_player_X1");
            entity.Property(e => e.HomePlayerX10).HasColumnName("home_player_X10");
            entity.Property(e => e.HomePlayerX11).HasColumnName("home_player_X11");
            entity.Property(e => e.HomePlayerX2).HasColumnName("home_player_X2");
            entity.Property(e => e.HomePlayerX3).HasColumnName("home_player_X3");
            entity.Property(e => e.HomePlayerX4).HasColumnName("home_player_X4");
            entity.Property(e => e.HomePlayerX5).HasColumnName("home_player_X5");
            entity.Property(e => e.HomePlayerX6).HasColumnName("home_player_X6");
            entity.Property(e => e.HomePlayerX7).HasColumnName("home_player_X7");
            entity.Property(e => e.HomePlayerX8).HasColumnName("home_player_X8");
            entity.Property(e => e.HomePlayerX9).HasColumnName("home_player_X9");
            entity.Property(e => e.HomePlayerY1).HasColumnName("home_player_Y1");
            entity.Property(e => e.HomePlayerY10).HasColumnName("home_player_Y10");
            entity.Property(e => e.HomePlayerY11).HasColumnName("home_player_Y11");
            entity.Property(e => e.HomePlayerY2).HasColumnName("home_player_Y2");
            entity.Property(e => e.HomePlayerY3).HasColumnName("home_player_Y3");
            entity.Property(e => e.HomePlayerY4).HasColumnName("home_player_Y4");
            entity.Property(e => e.HomePlayerY5).HasColumnName("home_player_Y5");
            entity.Property(e => e.HomePlayerY6).HasColumnName("home_player_Y6");
            entity.Property(e => e.HomePlayerY7).HasColumnName("home_player_Y7");
            entity.Property(e => e.HomePlayerY8).HasColumnName("home_player_Y8");
            entity.Property(e => e.HomePlayerY9).HasColumnName("home_player_Y9");
            entity.Property(e => e.HomeTeamApiId).HasColumnName("home_team_api_id");
            entity.Property(e => e.HomeTeamGoal).HasColumnName("home_team_goal");
            entity.Property(e => e.Iwa).HasColumnName("IWA");
            entity.Property(e => e.Iwd).HasColumnName("IWD");
            entity.Property(e => e.Iwh).HasColumnName("IWH");
            entity.Property(e => e.Lba).HasColumnName("LBA");
            entity.Property(e => e.Lbd).HasColumnName("LBD");
            entity.Property(e => e.Lbh).HasColumnName("LBH");
            entity.Property(e => e.LeagueId).HasColumnName("league_id");
            entity.Property(e => e.MatchApiId).HasColumnName("match_api_id");
            entity.Property(e => e.Possession)
                .HasColumnType("ntext")
                .HasColumnName("possession");
            entity.Property(e => e.Psa).HasColumnName("PSA");
            entity.Property(e => e.Psd).HasColumnName("PSD");
            entity.Property(e => e.Psh).HasColumnName("PSH");
            entity.Property(e => e.Season)
                .HasColumnType("ntext")
                .HasColumnName("season");
            entity.Property(e => e.Shotoff)
                .HasColumnType("ntext")
                .HasColumnName("shotoff");
            entity.Property(e => e.Shoton)
                .HasColumnType("ntext")
                .HasColumnName("shoton");
            entity.Property(e => e.Sja).HasColumnName("SJA");
            entity.Property(e => e.Sjd).HasColumnName("SJD");
            entity.Property(e => e.Sjh).HasColumnName("SJH");
            entity.Property(e => e.Stage).HasColumnName("stage");
            entity.Property(e => e.Vca).HasColumnName("VCA");
            entity.Property(e => e.Vcd).HasColumnName("VCD");
            entity.Property(e => e.Vch).HasColumnName("VCH");
            entity.Property(e => e.Wha).HasColumnName("WHA");
            entity.Property(e => e.Whd).HasColumnName("WHD");
            entity.Property(e => e.Whh).HasColumnName("WHH");

            entity.HasOne(d => d.Country).WithMany(p => p.Matches)
                .HasForeignKey(d => d.CountryId)
                .HasConstraintName("FK_Country_Match");

            entity.HasOne(d => d.League).WithMany(p => p.Matches)
                .HasForeignKey(d => d.LeagueId)
                .HasConstraintName("FK_League_Match");
        });

        modelBuilder.Entity<Player>(entity =>
        {
            entity.ToTable("Player");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Birthday)
                .HasColumnType("ntext")
                .HasColumnName("birthday");
            entity.Property(e => e.Height).HasColumnName("height");
            entity.Property(e => e.PlayerApiId).HasColumnName("player_api_id");
            entity.Property(e => e.PlayerFifaApiId).HasColumnName("player_fifa_api_id");
            entity.Property(e => e.PlayerName)
                .HasColumnType("ntext")
                .HasColumnName("player_name");
            entity.Property(e => e.Weight).HasColumnName("weight");
        });

        modelBuilder.Entity<PlayerAttribute>(entity =>
        {
            entity.ToTable("Player_Attributes");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Acceleration).HasColumnName("acceleration");
            entity.Property(e => e.Aggression).HasColumnName("aggression");
            entity.Property(e => e.Agility).HasColumnName("agility");
            entity.Property(e => e.AttackingWorkRate)
                .HasColumnType("ntext")
                .HasColumnName("attacking_work_rate");
            entity.Property(e => e.Balance).HasColumnName("balance");
            entity.Property(e => e.BallControl).HasColumnName("ball_control");
            entity.Property(e => e.Crossing).HasColumnName("crossing");
            entity.Property(e => e.Curve).HasColumnName("curve");
            entity.Property(e => e.Date)
                .HasColumnType("ntext")
                .HasColumnName("date");
            entity.Property(e => e.DefensiveWorkRate)
                .HasColumnType("ntext")
                .HasColumnName("defensive_work_rate");
            entity.Property(e => e.Dribbling).HasColumnName("dribbling");
            entity.Property(e => e.Finishing).HasColumnName("finishing");
            entity.Property(e => e.FreeKickAccuracy).HasColumnName("free_kick_accuracy");
            entity.Property(e => e.GkDiving).HasColumnName("gk_diving");
            entity.Property(e => e.GkHandling).HasColumnName("gk_handling");
            entity.Property(e => e.GkKicking).HasColumnName("gk_kicking");
            entity.Property(e => e.GkPositioning).HasColumnName("gk_positioning");
            entity.Property(e => e.GkReflexes).HasColumnName("gk_reflexes");
            entity.Property(e => e.HeadingAccuracy).HasColumnName("heading_accuracy");
            entity.Property(e => e.Interceptions).HasColumnName("interceptions");
            entity.Property(e => e.Jumping).HasColumnName("jumping");
            entity.Property(e => e.LongPassing).HasColumnName("long_passing");
            entity.Property(e => e.LongShots).HasColumnName("long_shots");
            entity.Property(e => e.Marking).HasColumnName("marking");
            entity.Property(e => e.OverallRating).HasColumnName("overall_rating");
            entity.Property(e => e.Penalties).HasColumnName("penalties");
            entity.Property(e => e.PlayerApiId).HasColumnName("player_api_id");
            entity.Property(e => e.PlayerFifaApiId).HasColumnName("player_fifa_api_id");
            entity.Property(e => e.Positioning).HasColumnName("positioning");
            entity.Property(e => e.Potential).HasColumnName("potential");
            entity.Property(e => e.PreferredFoot)
                .HasColumnType("ntext")
                .HasColumnName("preferred_foot");
            entity.Property(e => e.Reactions).HasColumnName("reactions");
            entity.Property(e => e.ShortPassing).HasColumnName("short_passing");
            entity.Property(e => e.ShotPower).HasColumnName("shot_power");
            entity.Property(e => e.SlidingTackle).HasColumnName("sliding_tackle");
            entity.Property(e => e.SprintSpeed).HasColumnName("sprint_speed");
            entity.Property(e => e.Stamina).HasColumnName("stamina");
            entity.Property(e => e.StandingTackle).HasColumnName("standing_tackle");
            entity.Property(e => e.Strength).HasColumnName("strength");
            entity.Property(e => e.Vision).HasColumnName("vision");
            entity.Property(e => e.Volleys).HasColumnName("volleys");
        });

        modelBuilder.Entity<Team>(entity =>
        {
            entity.ToTable("Team");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.TeamApiId).HasColumnName("team_api_id");
            entity.Property(e => e.TeamFifaApiId).HasColumnName("team_fifa_api_id");
            entity.Property(e => e.TeamLongName)
                .HasColumnType("ntext")
                .HasColumnName("team_long_name");
            entity.Property(e => e.TeamShortName)
                .HasColumnType("ntext")
                .HasColumnName("team_short_name");
        });

        modelBuilder.Entity<TeamAttribute>(entity =>
        {
            entity.ToTable("Team_Attributes");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.BuildUpPlayDribbling).HasColumnName("buildUpPlayDribbling");
            entity.Property(e => e.BuildUpPlayDribblingClass)
                .HasColumnType("ntext")
                .HasColumnName("buildUpPlayDribblingClass");
            entity.Property(e => e.BuildUpPlayPassing).HasColumnName("buildUpPlayPassing");
            entity.Property(e => e.BuildUpPlayPassingClass)
                .HasColumnType("ntext")
                .HasColumnName("buildUpPlayPassingClass");
            entity.Property(e => e.BuildUpPlayPositioningClass)
                .HasColumnType("ntext")
                .HasColumnName("buildUpPlayPositioningClass");
            entity.Property(e => e.BuildUpPlaySpeed).HasColumnName("buildUpPlaySpeed");
            entity.Property(e => e.BuildUpPlaySpeedClass)
                .HasColumnType("ntext")
                .HasColumnName("buildUpPlaySpeedClass");
            entity.Property(e => e.ChanceCreationCrossing).HasColumnName("chanceCreationCrossing");
            entity.Property(e => e.ChanceCreationCrossingClass)
                .HasColumnType("ntext")
                .HasColumnName("chanceCreationCrossingClass");
            entity.Property(e => e.ChanceCreationPassing).HasColumnName("chanceCreationPassing");
            entity.Property(e => e.ChanceCreationPassingClass)
                .HasColumnType("ntext")
                .HasColumnName("chanceCreationPassingClass");
            entity.Property(e => e.ChanceCreationPositioningClass)
                .HasColumnType("ntext")
                .HasColumnName("chanceCreationPositioningClass");
            entity.Property(e => e.ChanceCreationShooting).HasColumnName("chanceCreationShooting");
            entity.Property(e => e.ChanceCreationShootingClass)
                .HasColumnType("ntext")
                .HasColumnName("chanceCreationShootingClass");
            entity.Property(e => e.Date)
                .HasColumnType("ntext")
                .HasColumnName("date");
            entity.Property(e => e.DefenceAggression).HasColumnName("defenceAggression");
            entity.Property(e => e.DefenceAggressionClass)
                .HasColumnType("ntext")
                .HasColumnName("defenceAggressionClass");
            entity.Property(e => e.DefenceDefenderLineClass)
                .HasColumnType("ntext")
                .HasColumnName("defenceDefenderLineClass");
            entity.Property(e => e.DefencePressure).HasColumnName("defencePressure");
            entity.Property(e => e.DefencePressureClass)
                .HasColumnType("ntext")
                .HasColumnName("defencePressureClass");
            entity.Property(e => e.DefenceTeamWidth).HasColumnName("defenceTeamWidth");
            entity.Property(e => e.DefenceTeamWidthClass)
                .HasColumnType("ntext")
                .HasColumnName("defenceTeamWidthClass");
            entity.Property(e => e.TeamApiId).HasColumnName("team_api_id");
            entity.Property(e => e.TeamFifaApiId).HasColumnName("team_fifa_api_id");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
