import java.awt.*;
class Addition extends Frame {
	Label lbl_augend, lbl_addend, lbl_sum;
	TextField txt_augend, txt_addend, txt_sum;
	Button btn_add;
	
	Addition() {
	//----lbl_augend--------------
		lbl_augend = new Label("Augend");
		lbl_augend.setBounds(60,120, 50, 30);
		add(lbl_augend);
		
	//-----txt_augend--------------
		txt_augend = new TextField();
		txt_augend.setBounds(120,120,50,30);
		add(txt_augend);
		
	//----lbl_addend--------------
		lbl_addend = new Label("Addend");
		lbl_addend.setBounds(60,180, 50, 30);
		add(lbl_addend);
		
	//-----txt_addend--------------
		txt_addend = new TextField();
		txt_addend.setBounds(120,180,50,30);
		add(txt_addend);
		
	//----lbl_sum--------------
		lbl_sum = new Label("Sum");
		lbl_sum.setBounds(60,240, 50, 30);
		add(lbl_sum);
		
	//-----txt_sum--------------
		txt_sum = new TextField();
		txt_sum.setBounds(120,240,50,30);
		add(txt_sum);
		
	//----btn_add---------------
		btn_add = new Button("Add");
		btn_add.setBounds(60, 300, 50, 30);
		this.add(btn_add);
		
		
	//-------Frame Properties
		this.setLayout(null);
		this.setSize(500, 500);
		this.setVisible(true);
		this.setTitle("Addition App");
	}
}

class AdditionGUI {
	public static void main(String[] args) {
		new Addition();
	}
}
