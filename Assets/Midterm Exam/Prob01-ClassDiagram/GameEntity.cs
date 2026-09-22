using Unity.VisualScripting;
using UnityEngine;

namespace MidtermExam.Prob01
{
    public class GameEntity
    {
        // TODO: Implement fields and methods according to Class Diagram
        public string id;
        private Vector3 position;
        protected int Health;

        public virtual void Update()
        {
            
        }

        public virtual void TakeDamage(int damage)
        {
            Health -= damage;
        }

        private void Move(Vector3 direction)
        {
            position += direction;
        }

    }
}
