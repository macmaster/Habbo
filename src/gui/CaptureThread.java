/********************CaptureThread******************************
 * Capture Thread for the Habbo Packet Logger
 * 
 * Author: Ronny Macmaster
 * Date: 3/27/16
 ***************************************************************/

package gui;

import javax.swing.*;

public class CaptureThread{

	public CaptureThread(){
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
