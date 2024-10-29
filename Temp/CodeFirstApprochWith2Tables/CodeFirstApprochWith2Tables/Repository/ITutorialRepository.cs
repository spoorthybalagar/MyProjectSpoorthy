using CodeFirstApprochWith2Tables.Models;
namespace CodeFirstApprochWith2Tables.Repository
{
    public interface ITutorialRepository
    {
        Tutorial AddTutorial(Tutorial tutorial);
        Tutorial UpdateTutorial(Tutorial tutorial);
        string DeleteTutorial(int id);
        Tutorial GetTutorialById(int id);
        IEnumerable<Tutorial> GetAllTutorial();
        IEnumerable<Tutorial> GetTutorialByArticleId(int articleId);
    }
}
