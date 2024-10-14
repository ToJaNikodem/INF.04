package com.example.inf04_02_2401_sginf04_01_2401_sd;

import android.os.Bundle;
import android.view.View;
import android.widget.AdapterView;
import android.widget.ArrayAdapter;
import android.widget.ListView;
import android.widget.SeekBar;
import android.widget.TextView;

import androidx.activity.EdgeToEdge;
import androidx.appcompat.app.AppCompatActivity;
import androidx.core.graphics.Insets;
import androidx.core.view.ViewCompat;
import androidx.core.view.WindowInsetsCompat;

import java.util.ArrayList;

public class MainActivity extends AppCompatActivity {

    ArrayList<String> species;
    ArrayAdapter<String> adapter;
    ListView speciesList;

    String selectedSpecies = "Pies";
    int age = 0;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        EdgeToEdge.enable(this);
        setContentView(R.layout.activity_main);
        ViewCompat.setOnApplyWindowInsetsListener(findViewById(R.id.main), (v, insets) -> {
            Insets systemBars = insets.getInsets(WindowInsetsCompat.Type.systemBars());
            v.setPadding(systemBars.left, systemBars.top, systemBars.right, systemBars.bottom);
            return insets;
        });
        species = new ArrayList<>();
        species.add("Pies");
        species.add("Kot");
        species.add("Świnka morska");

        adapter = new ArrayAdapter<>(this, android.R.layout.simple_list_item_1, species);
        adapter.notifyDataSetChanged();

        speciesList = findViewById(R.id.speciesList);
        speciesList.setAdapter(adapter);

        TextView ageText = findViewById(R.id.ageText);
        SeekBar ageSeekBar = findViewById(R.id.ageSeekBar);
        ageSeekBar.setOnSeekBarChangeListener(new SeekBar.OnSeekBarChangeListener() {
            @Override
            public void onProgressChanged(SeekBar seekBar, int i, boolean b) {
                ageText.setText("Ile ma lat? " + i);
                age = i;
            }

            @Override
            public void onStartTrackingTouch(SeekBar seekBar) {

            }

            @Override
            public void onStopTrackingTouch(SeekBar seekBar) {

            }
        });

        speciesList.setOnItemClickListener(new AdapterView.OnItemClickListener() {
            @Override
            public void onItemClick(AdapterView<?> adapterView, View view, int i, long l) {
                selectedSpecies = species.get(i);
                switch (selectedSpecies) {
                    case "Pies":
                        ageSeekBar.setMax(18);
                        break;
                    case "Kot":
                        ageSeekBar.setMax(20);
                        break;
                    case "Świnka morska":
                        ageSeekBar.setMax(9);
                        break;
                }
            }
        });
    }

    public void submit(View view) {
        TextView summary = findViewById(R.id.summary);
        TextView name = findViewById(R.id.name);
        TextView visitPurpose = findViewById(R.id.visitPurpose);
        TextView visitTime = findViewById(R.id.visitTime);

        summary.setText(name.getText() + ", " + selectedSpecies + ", " + age + ", " + visitPurpose.getText() + ", " + visitTime.getText());
    }
}