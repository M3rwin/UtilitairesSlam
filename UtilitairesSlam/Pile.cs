using System;
using System.Collections.Generic;

namespace UtilitairesSlam
{

    /// <summary>
    /// Pile pouvant contenir des entiers.
    /// On ajoute après le dernier élément ajouté.
    /// On retire toujours le dernier élément ajouté.
    /// </summary>
    public class Pile<T>
    {
        /// <summary>
        /// Liste contenant les éléments de la Pile
        /// </summary>
        private List<T> elements;

        /// <summary>
        /// Obtient le nombre d'éléments actuellement présent dans la Pile
        /// </summary>
        private int Count { get => this.elements.Count; }

        /// <summary>
        /// Constructeur de la classe Pile
        /// </summary>
        /// <param name="nbMaxElt"></param>
        public Pile(int nbMaxElt)
        {
            this.elements = new List<T>(); // On initialise la liste de l'objet créé par le constructeur.
        }



        //--------------------------------------------------------------------------------------------------
        // méthodes
        //--------------------------------------------------------------------------------------------------



        /// <summary>
        /// Fonction permettant de savoir si la liste de l'objet
        /// ayant appelé la méthode est vide ou non.
        /// </summary>
        /// <returns>Booléen</returns>
        public bool PileVide()
        {
            return this.elements.Count == 0;
        }
        
        /// <summary>
        /// Fonction permettant d'empiler un nombre dans la Pile
        /// </summary>
        /// <param name="valeur">Valeur à ajouter</param>
        public void Empiler(T valeur)
        {
            this.elements.Add(valeur);
        }

        
        /// <summary>
        /// Fonction permettant de dépiler le dernier élément de la Pile
        /// Renvoie un message d'erreur lorsque la Pile est déjà vide,
        /// sinon le contenu de l'élément dépilé.
        /// </summary>
        /// <returns>int</returns>
        /// <exception cref="Exception"></exception>
        public T Depiler()
        {
            if (!this.PileVide())
            {
                int sommet = this.elements.Count - 1 ;
                T rep = this.elements[sommet];
                this.elements.RemoveAt(sommet);
                return rep;
            } else
            {
                throw new Exception("Impossible de dépiler, la pile est vide");
            }
        }

    }
}
