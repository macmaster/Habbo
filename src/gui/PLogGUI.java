/********************PLogGUI**********************************
 * Habbo Packet Logger GUI
 * Applet for Habbo packet logger
 * 
 * Author: Ronny Macmaster
 * Date: 3/27/16
 ***************************************************************/
package gui;

import javax.swing.*;

public class PLogGUI{
	public static void main(String[] args){
		SwingUtilities.invokeLater(new Runnable(){
			public void run(){
				MainFrame frame = new MainFrame("PLog Swing GUI");
				frame.setSize(400, 400);
				frame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
				frame.setVisible(true);
			}
		});
	}
}
