using CodeFirstApprochWith2Tables.Models;
using Microsoft.EntityFrameworkCore;

using CodeFirstApprochWith2Tables.Models;

namespace CodeFirstApprochWith2Tables.Repository
{
    public class TutorialRepository : ITutorialRepository
    {
        private readonly TutorialDbContext _context;
        public TutorialRepository(TutorialDbContext context)
        {
            _context = context;
        }
        public Tutorial AddTutorial(Tutorial tutorial)
        {
            //throw new NotImplementedException();
            using (var transaction = _context.Database.BeginTransaction())
            {
                _context.Database.ExecuteSqlRaw("SET IDENTITY_INSERT dbo. [Tutorials] ON");
                _context.Add(tutorial);
                _context.SaveChanges();
                transaction.Commit();
                return tutorial;
            }
        }

        public string DeleteTutorial(int id)
        {
            //throw new NotImplementedException();
            if (id > 0)
            {
                Tutorial tutorial = _context.Tutorials.FirstOrDefault(a => a.TutorialId == id);
                if (tutorial != null)
                {
                    _context.Tutorials.Remove(tutorial);
                    _context.SaveChanges();
                    return "Tutorial removed";
                }
                else
                {
                    return "Id not Found";
                }
            }
            else
            { return "Id is not valid"; }
        }

        public IEnumerable<Tutorial> GetAllTutorial()
        {
            //throw new NotImplementedException();
            var tutorials = _context.Tutorials;
            if (tutorials != null)
                return tutorials;
            else
                return null;
        }

       

        public Tutorial GetTutorialById(int id)
        {
            //throw new NotImplementedException();
            if (id != 0 || id != null)
            {
                var tutorial = _context.Tutorials.FirstOrDefault(a => a.TutorialId == id);
                if (tutorial != null)
                    return tutorial;
            }
            return null;
        }
        public IEnumerable<Tutorial> GetTutorialByArticleId(int articleId)
        {
            //throw new NotImplementedException();
            return _context.Tutorials.Where(a => a.TutorialId == articleId).ToList();
        }

        public Tutorial UpdateTutorial(Tutorial newtutorial)
        {
            //throw new NotImplementedException();
            if (newtutorial != null)
            {
                var tuto = _context.Tutorials.FirstOrDefault(a => a.TutorialId == newtutorial.TutorialId);
                if (tuto != null)
                {
                    tuto.TutorialName = newtutorial.TutorialName;
                    tuto.TutorialDescription = newtutorial.TutorialDescription;
                    //tuto.ArticleId = newtutorial.ArticleId;
                    _context.Entry(tuto).State = EntityState.Modified;
                    _context.SaveChanges();

                }
                return newtutorial;
            }
            return null;
        }
    }
    }

