using Microsoft.EntityFrameworkCore;
using SongsAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SongsAPI.Data
{
    public class SongContext : DbContext
    {
        //Constructor
        public SongContext(DbContextOptions<SongContext> options) : base(options)
        {

        }

        //Creating table
        public DbSet<Song> Songs { set; get; }
    }
}
