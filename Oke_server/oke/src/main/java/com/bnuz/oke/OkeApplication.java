package com.bnuz.oke;

import org.springframework.boot.SpringApplication;
import org.springframework.boot.autoconfigure.SpringBootApplication;
import org.springframework.web.socket.config.annotation.EnableWebSocket;

@EnableWebSocket
@SpringBootApplication
public class OkeApplication {

	public static void main(String[] args) {
		SpringApplication.run(OkeApplication.class, args);
	}

}
