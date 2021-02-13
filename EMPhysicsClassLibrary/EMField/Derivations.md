﻿# Derivations

This markdown file includes the derivations of the equations used for computing various quantities of
the [electromagnetic field](https://en.wikipedia.org/wiki/Electromagnetic_field).

## Retarded potentials

This section includes the derivations of the equations used to compute the 
[retarded potentials](https://en.wikipedia.org/wiki/Retarded_potential), defined in the Wikipedia article as

$$ \phi(\vec{r}, t) = \frac{1}{4 \pi \epsilon_0} \int \frac{\rho(\vec{r'}, t_r)}{|\vec{r} - \vec{r'}|} d \vec{r'} $$
$$ \vec{A}(\vec{r}, t) = \frac{\mu_0}{4 \pi} \int \frac{\vec{J}(\vec{r'}, t_r)}{|\vec{r} - \vec{r'}|} d \vec{r'} $$

where $$\phi(\vec{r}, t)$$ is the retarded [electric potential](https://en.wikipedia.org/wiki/Electric_potential),
$$\vec{A}(\vec{r}, t)$$ is the retarded [magnetic vector potential](https://en.wikipedia.org/wiki/Magnetic_vector_potential),
$$\rho(\vec{r'}, t)$$ is the [charge density](https://en.wikipedia.org/wiki/Charge_density),
$$\vec{J}(\vec{r'}, t_r)$$ is the [current density](https://en.wikipedia.org/wiki/Current_density), and
$$t_r = t - \frac{|\vec{r} - \vec{r'}|}{c}$$ is the [retarded time](https://en.wikipedia.org/wiki/Retarded_time).

### The effect of a time-invariant point charge on $$\phi(\vec{r}, t)$$

The time-invariant point charge is modeled as having [charge density](https://en.wikipedia.org/wiki/Charge_density)

$$ \rho(\vec{r}, t) = q \delta(\vec{r} - \vec{r_c}) $$

where $$q$$ is the [electric charge](https://en.wikipedia.org/wiki/Electric_charge), $$\vec{r_c}$$ is the position 
vector of the point charge, and $$\delta(\vec{x})$$ is the [Dirac delta function](https://en.wikipedia.org/wiki/Dirac_delta_function), 
generalized in the Wikipedia article to multiple dimensions via the identity

$$ \int_{R^n} f(\vec{x}) \delta(\vec{x}) d\vec{x} = f(\vec{0}) $$

which allows us to rewrite the equation for the retarded [electric potential](https://en.wikipedia.org/wiki/Electric_potential) as

$$ \phi(\vec{r}, t) = \frac{1}{4 \pi \epsilon_0} \frac{q}{|\vec{r} - \vec{r_c}|} $$

meaning that, becouse [integration](https://en.wikipedia.org/wiki/Integral) is linear, the effect of a group 
of point charges on $$\phi(\vec{r}, t)$$ can be modeled as sum of such components.

### The effect of a time-invariant point charge on $$\nabla \phi(\vec{r}, t)$$

Using the result of the previous section, the effect a time-invariant point charge has on the
[gradient](https://en.wikipedia.org/wiki/Gradient) of $$\phi(\vec{r}, t)$$ is

$$ \nabla \phi(\vec{r}, t) = \nabla \left( \frac{1}{4 \pi \epsilon_0} \frac{q}{|\vec{r} - \vec{r_c}|} \right) = 
\frac{q}{4 \pi \epsilon_0} \nabla \left( \frac{1}{|\vec{r} - \vec{r_c}|} \right) = 
\frac{q}{4 \pi \epsilon_0} \frac{\vec{r_c} - \vec{r}}{|\vec{r} - \vec{r_c}|^3} $$