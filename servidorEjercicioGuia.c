#include <string.h>
#include <unistd.h>
#include <stdlib.h>
#include <sys/types.h>
#include <sys/socket.h>
#include <netinet/in.h>
#include <stdio.h>
/*
 1/ tamaño nombre
 2/ nombre bonito
 3/ si soy alto
 0/ desconexion
 4/ nombres conectados
 5/ invitar a jugar
 6/ palindromo
 7/ mayusculas
*/

int main(int argc, char *argv[])
{
	int sock_conn, sock_listen, ret;
	struct sockaddr_in serv_adr;
	char peticion[512];
	char respuesta[512];
	// INICIALITZACIONS
	// Obrim el socket
	if ((sock_listen = socket(AF_INET, SOCK_STREAM, 0)) < 0)
		printf("Error creant socket");
	// Fem el bind al port
	memset(&serv_adr, 0, sizeof(serv_adr));// inicialitza a zero serv_addr
	serv_adr.sin_family = AF_INET;
	// asocia el socket a cualquiera de las IP de la m?quina. 
	//htonl formatea el numero que recibe al formato necesario
	serv_adr.sin_addr.s_addr = htonl(INADDR_ANY);
	// escucharemos en el port 9050
	serv_adr.sin_port = htons(9050);
	if (bind(sock_listen, (struct sockaddr *) &serv_adr, sizeof(serv_adr)) < 0)
		printf ("Error al bind");
	//La cola de peticiones pendientes no podr? ser superior a 4
	if (listen(sock_listen, 4) < 0)
		printf("Error en el Listen");
	int i;
	// Atenderemos solo 10 peticione
	for(;;){
		printf ("Escuchando\n");
		
		sock_conn = accept(sock_listen, NULL, NULL);
		printf ("He recibido conexi?n\n");
		//sock_conn es el socket que usaremos para este cliente
		
		int terminar = 0;
		while(terminar == 0){
		
			// Ahora recibimos su peticion
			ret=read(sock_conn,peticion, sizeof(peticion));
			printf ("Recibida una petición\n");
			// Tenemos que a?adirle la marca de fin de string 
			// para que no escriba lo que hay despues en el buffer
			peticion[ret]='\0';
			
			//Escribimos la peticion en la consola
			
			printf ("La petición es: %s\n",peticion);
			char *p = strtok(peticion, "/");
			int codigo =  atoi (p);
			char nombre[20];
			if (codigo != 0){
				p = strtok( NULL, "/");
				
				strcpy (nombre, p);
				printf ("Codigo: %d, Nombre: %s\n", codigo, nombre);
			}
			if(codigo == 0)
				terminar = 1;
			else if (codigo ==1) //piden la longitd del nombre
				sprintf (respuesta,"%d",strlen (nombre));
			else if (codigo == 2)
				// quieren saber si el nombre es bonito
				if((nombre[0]=='M') || (nombre[0]=='S'))
				strcpy (respuesta,"SI");
				else
					strcpy (respuesta,"NO");
			else if(codigo ==3)//decir si es alto
				{
					p = strtok(NULL,"/");
					float altura = atof(p);
					if (altura > 1.70)
						sprintf(respuesta,"%s: eres alto", nombre);
					else
						sprintf(respuesta,"%s: eres bajo", nombre);
				}
			else if (codigo == 6){
				//saber si mi nombre es palindromo
				int i;
				int j;
				int h;
				int r;
				char mitad1 [20];
				char mitad2[20];
				for(i=0;i<strlen(nombre);i++){
					
						j = strlen(nombre) / 2;
						for(h=0;h<j;h++){
							mitad1[h] = nombre[h];
						}
						for(h=strlen(nombre)-1; h>j; h--){
							r = 0;
							mitad2[r] = nombre[h];
							r++;
						}
						if (mitad1 == mitad2){
							strcpy (respuesta, "SI");
						}
						else
							strcpy(respuesta,"NO");
				}
				}
			else if (codigo == 7){
				//devolver nombre en mayusculas
				int i;
				for (i=0;i<strlen(nombre);i++){
					nombre[i] = toupper(nombre[i]);
				}
				sprintf(respuesta, "%c", nombre);
			}
			if (codigo !=0)	{
				printf("Respuesta: s&\n", respuesta);
				// Enviamos la respuesta
			
				write (sock_conn,respuesta, strlen(respuesta));
				}
		}
		// Se acabo el servicio para este cliente
		close(sock_conn); 
		
	}
}
