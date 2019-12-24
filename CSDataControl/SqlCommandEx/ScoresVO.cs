using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlCommandEx
{
    class ScoresVO
    {
        public int Id { get; set; }
        public string Class { get; set; }
        public int Score { get; set; }
        public DateTime LastUpdate { get; set; }

        public ScoresVO()
        {
        }

        public ScoresVO(int id, string @class, int score, DateTime lastUpdate)
        {
            Id = id;
            Class = @class;
            Score = score;
            LastUpdate = lastUpdate;
        }

        public override bool Equals(object obj)
        {
            var vO = obj as ScoresVO;
            return vO != null &&
                   Id == vO.Id &&
                   Class == vO.Class &&
                   Score == vO.Score &&
                   LastUpdate == vO.LastUpdate;
        }

        public override int GetHashCode()
        {
            var hashCode = -452223036;
            hashCode = hashCode * -1521134295 + Id.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Class);
            hashCode = hashCode * -1521134295 + Score.GetHashCode();
            hashCode = hashCode * -1521134295 + LastUpdate.GetHashCode();
            return hashCode;
        }

        public override string ToString()
        {
            return $"{{{nameof(Id)}={Id.ToString()}, {nameof(Class)}={Class}, {nameof(Score)}={Score.ToString()}, {nameof(LastUpdate)}={LastUpdate.ToString()}}}";
        }
    }
}
