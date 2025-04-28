using POO_C_.Models;

namespace POO_C_.Interfaces;

internal interface IRatable
{
    void Rate(Evaluation rate);
    double Average {  get; }
}
