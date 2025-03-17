#ifndef __ITINERAIRE__LIB__H
#define __ITINERAIRE__LIB__H

#include <iostream>
using namespace std;

typedef enum
{
    DISTANCE,
    FREQUENTATION
}Ponderation;


/*
Une classe pour représenter un arrêt de metro
*/
class Arret
{
private:
    /* data */
public:
    Arret(/* args */);
    ~Arret();
};

/*
Calcule un itinéraire optimal entre deux arrêts

\param depart : arrêt de départ de l’itinéraire à calculer
\param arrivee : arrêt d’arrivée de l’itinéraire à calculer
\param ponderation : indique la pondération à utiliser pour calculer l’itinéraire (ex : distance…)

\return liste des arrêts de l'itinéraire
*/
Arret **calcul_itineraire(Arret depart, Arret arrivee, Ponderation ponderation);

#endif