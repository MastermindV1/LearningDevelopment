package com.learning;

import org.springframework.context.ApplicationContext;
import org.springframework.context.support.ClassPathXmlApplicationContext;

public class MainApp 
{
	public static void main(String[] args) 
	{
		ApplicationContext context = null;
		try 
		{
			context = new ClassPathXmlApplicationContext("Beans.xml");
			IMessage obj = (HelloWorld) context.getBean("helloWorld");
			obj.getMessage();
		} 
		catch (Exception e) 
		{
			e.printStackTrace();
		}
	}
}
