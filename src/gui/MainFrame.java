/********************MainFrame***********************************
 * Frame container for swing
 * Encapsulates the JFrame for custom use
 * 
 * Author: Ronny Macmaster
 * Date: 3/27/16
 ***************************************************************/
package gui;

import java.awt.BorderLayout;
import java.awt.Container;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;

import javax.swing.*;

public class MainFrame extends JFrame{

	public MainFrame(String title){
		super(title);
		
		// 1) set layout manager
		setLayout(new BorderLayout());
		
		// 2) create swing components
		JTextArea textArea = new JTextArea();
		JButton button = new JButton("click me!");
		
		// 3) add swing componenets to content panel
		Container c = getContentPane();
		c.add(textArea, BorderLayout.CENTER);
		c.add(button, BorderLayout.SOUTH);
		
		// 4) add behavior
		button.addActionListener(new ActionListener(){
			@Override
			public void actionPerformed(ActionEvent arg0){
				textArea.append("Hello!\n");
			}
		});

	}

}
