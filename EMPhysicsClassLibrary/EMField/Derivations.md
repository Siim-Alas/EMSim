# Derivations

This markdown file includes the derivations of the equations used for computing various quantities of
the [electromagnetic field](https://en.wikipedia.org/wiki/Electromagnetic_field).

## Retarded potentials

This section includes the derivations of the equations used to compute the 
[retarded potentials](https://en.wikipedia.org/wiki/Retarded_potential), defined in the Wikipedia article as

<pre xml:lang="latex">\phi(\vec{r}, t) = \frac{1}{4 \pi \epsilon_0} \int \frac{\rho(\vec{r'}, t_r)}{|\vec{r} - \vec{r'}|} d \vec{r'}</pre>
<pre xml:lang="latex">\vec{A}(\vec{r}, t) = \frac{\mu_0}{4 \pi} \int \frac{\vec{J}(\vec{r'}, t_r)}{|\vec{r} - \vec{r'}|} d \vec{r'}</pre>

where <pre xml:lang="latex">\phi(\vec{r}, t)</pre> is the retarded [electric potential](https://en.wikipedia.org/wiki/Electric_potential),
<pre xml:lang="latex">\vec{A}(\vec{r}, t)</pre> is the retarded [magnetic vector potential](https://en.wikipedia.org/wiki/Magnetic_vector_potential),
<pre xml:lang="latex">\rho(\vec{r'}, t)</pre> is the [charge density](https://en.wikipedia.org/wiki/Charge_density),
<pre xml:lang="latex">\vec{J}(\vec{r'}, t_r)</pre> is the [current density](https://en.wikipedia.org/wiki/Current_density), and
<pre xml:lang="latex">t_r = t - \frac{|\vec{r} - \vec{r'}|}{c}</pre> is the [retarded time](https://en.wikipedia.org/wiki/Retarded_time).

### The effect of a time-invariant point charge on <pre xml:lang="latex">\phi(\vec{r}, t)</pre>

The time-invariant point charge is modeled as having [charge density](https://en.wikipedia.org/wiki/Charge_density)

<pre xml:lang="latex">\rho(\vec{r}, t) = q \delta(\vec{r} - \vec{r_c})</pre>

where <pre xml:lang="latex">q</pre> is the [electric charge](https://en.wikipedia.org/wiki/Electric_charge),
<pre xml:lang="latex">\vec{r_c}</pre> is the position vector of the point charge, and <pre xml:lang="latex">\delta(\vec{x})</pre> 
is the [Dirac delta function](https://en.wikipedia.org/wiki/Dirac_delta_function), generalized in the Wikipedia article to 
multiple dimensions via the identity

<pre xml:lang="latex">\int_{R^n} f(\vec{x}) \delta(\vec{x}) d\vec{x} = f(\vec{0})</pre>

which allows us to rewrite the equation for the retarded [electric potential](https://en.wikipedia.org/wiki/Electric_potential) as

<pre xml:lang="latex">\phi(\vec{r}, t) = \frac{1}{4 \pi \epsilon_0} \frac{q}{|\vec{r} - \vec{r_c}|}</pre>

meaning that, becouse [integration](https://en.wikipedia.org/wiki/Integral) is linear, the effect of a group 
of point charges on <pre xml:lang="latex">\phi(\vec{r}, t)</pre> can be modeled as sum of such components.

### The effect of a time-invariant point charge on <pre xml:lang="latex">\nabla \phi(\vec{r}, t)</pre>

Using the result of the previous section, the effect a time-invariant point charge has on the
[gradient](https://en.wikipedia.org/wiki/Gradient) of <pre xml:lang="latex">\phi(\vec{r}, t)</pre> is

<pre xml:lang="latex">\nabla \phi(\vec{r}, t) = \nabla \left( \frac{1}{4 \pi \epsilon_0} \frac{q}{|\vec{r} - \vec{r_c}|} \right) = 
\frac{q}{4 \pi \epsilon_0} \nabla \left( \frac{1}{|\vec{r} - \vec{r_c}|} \right) = 
\frac{q}{4 \pi \epsilon_0} \frac{\vec{r_c} - \vec{r}}{|\vec{r} - \vec{r_c}|^3}</pre>