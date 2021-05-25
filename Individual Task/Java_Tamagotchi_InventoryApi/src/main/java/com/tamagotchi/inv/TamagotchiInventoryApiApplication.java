package com.tamagotchi.inv;

import org.springframework.boot.SpringApplication;
import org.springframework.boot.autoconfigure.SpringBootApplication;
import org.springframework.cloud.client.discovery.EnableDiscoveryClient;

@SpringBootApplication
@EnableDiscoveryClient
public class TamagotchiInventoryApiApplication {

	public static void main(String[] args) {
		SpringApplication.run(TamagotchiInventoryApiApplication.class, args);
	}

}
