#language: es

Característica:	Inscripciones
	Como Steven el surfista, quiero realizar el pago de la inscripción en el momento en que me inscribo en un torneo 
	con el fin de asegurar mi espacio en el evento
	
Antecedentes:	
Dadas las siguientes marcas de tarjetas aceptadas
| Marca tarjeta    |
| VISA             |
| MASTERCARD       |
| AMERICAN EXPRESS |

Y los siguientes cupos por categoría 
| Categoría      | Cupos disponibles | Precio Inscripcion |
| Open Masculino | 15                | 13000              |
| Boys           | 13                | 10500              |
| Open Femenino  | 16                | 13000              |

Escenario: Solo puede realizarse un pago si para la categoría hay espacio libre.
Cuando Steven que es un usuario registrado solicita la inscripcion a la categoría "Open Masculino"
Entonces el cupo se reduce en 1 y ahora quedan "14" espacios disponibles
Y se emite un cobro por "13000" colones a la cuenta del surfista inscrito.

	
Escenario: Que se permita el pago en línea con una tarjeta de crédito ó débito VISA, MasterCard ó Amex.
Cuando Steven realiza el pago por inscripción a la categoría "Open Masculino" 
Y la marca de su tarjeta es "VISA"
Entonces se genera un cobro por "13000" colones exactos